using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using JetBrains.Annotations;
using JetBrains.Diagnostics;
using JetBrains.EnvDTE.Host.Manager;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Host.Features.ProjectModel.View;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Impl;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Rider.Model;
using JetBrains.Util;

namespace JetBrains.EnvDTE.Host.Callback.Impl
{
    [SolutionComponent]
    public sealed class CodeElementCallbackProvider : IEnvDteCallbackProvider
    {
        [NotNull]
        private ILogger Logger { get; } = JetBrains.Util.Logging.Logger.GetLogger<CodeElementCallbackProvider>();

        public void RegisterCallbacks(
            AstManager astManager,
            ISolution solution,
            ProjectModelViewHost host,
            DteProtocolModel model
        )
        {
            model.CodeElement_get_Children.SetWithReadLock(codeElementModel => astManager.MapElement(
                codeElementModel.Id,
                node => (
                    from child in node.GetEnvDTEModelChildren()
                    let childId = astManager.GetOrCreateId(child)
                    let childTypeId = PsiElementRegistrar.GetTypeId(child)
                    select new CodeElementModel(childTypeId, childId, true)
                ).ToList(),
                // It's not implemented in VS, so we don't have to do that, too
                element => throw new NotImplementedException()
            ));
            model.CodeElement_get_Access.SetWithReadLock(codeElementModel => astManager.MapElement(codeElementModel.Id, node =>
            {
                if (!(node is IAccessRightsOwner @class)) return Access.None;
                return @class.GetAccessRights() switch
                {
                    AccessRights.PUBLIC => Access.Public,
                    AccessRights.INTERNAL => Access.Internal,
                    AccessRights.PROTECTED => Access.Protected,
                    AccessRights.PROTECTED_OR_INTERNAL => Access.ProtectedInternal,
                    AccessRights.PROTECTED_AND_INTERNAL => Access.ProtectedInternal,
                    AccessRights.PRIVATE => Access.Private,
                    _ => Access.None
                };
            }, _));
            model.CodeElement_get_Name.SetWithReadLock(codeElementModel =>
            {
                var element = astManager.GetElement(codeElementModel.Id);
                return ElementNameProvider.FindName(element);
            });
            model.CodeElement_get_FullName.SetWithReadLock(codeElementModel =>
            {
                var element = astManager.GetElement(codeElementModel.Id);
                if (!(element is ICSharpDeclaration node)) return null;
                return CSharpSharedImplUtil.GetQualifiedName(node);
            });
            model.CodeElement_get_Bases.SetWithReadLock(codeElementModel =>
            {
                var element = astManager.GetElement(codeElementModel.Id);
                if (!(element is IClassDeclaration classDeclaration))
                {
                    throw new InvalidOperationException("Tried to find base for non-class element");
                }

                CodeElementModel ToModel(IList<IDeclaration> declarations, ITypeElement typeElement)
                {
                    if (declarations.IsEmpty())
                    {
                        int id = astManager.GetOrCreateId(typeElement);
                        int typeId = PsiElementRegistrar.GetTypeId(typeElement);
                        return new CodeElementModel(typeId, id, false);
                    }

                    if (declarations.IsSingle())
                    {
                        var declaration = declarations.Single();
                        int id = astManager.GetOrCreateId(declaration);
                        int typeId = PsiElementRegistrar.GetTypeId(declaration);
                        return new CodeElementModel(typeId, id, true);
                    }

                    Logger.Warn("Failed to create a model for base class because it resides in multiple locations");
                    return null;
                }

                var query = from type in classDeclaration.DeclaredElement.NotNull().GetSuperTypes()
                            let typeElement = type.GetTypeElement()
                            where typeElement != null
                            let declarations = typeElement.GetDeclarations()
                            let child = ToModel(declarations, typeElement)
                            where child != null
                            select child;

                return query.AsList();
            });
            model.CodeElement_get_ProjectItem.SetWithReadLock(codeElementModel =>
            {
                var sourceFile = astManager.GetElement(codeElementModel.Id).GetSourceFile();
                var projectFile = sourceFile.ToProjectFile().NotNull();
                return new ProjectItemModel(host.GetIdByItem(projectFile));
            });
        }
    }
}

