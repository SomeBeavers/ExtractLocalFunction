using System;
using System.Collections;
using System.Collections.Generic;

class Program1
{
    public static IEnumerable<ITagPrefixHolder> GetRelevantHolders(IPsiSourceFile sourceFile)
    {
        var targetPath = FileSystemPath.Empty;
        var projectFile = sourceFile.ToProjectFile();
        if (projectFile != null)
            targetPath = projectFile.Location;

        foreach (var holder in GetRelevantHoldersBeforeFile(sourceFile, targetPath))
            yield return holder;

        foreach (var holder in GetHoldersInFile(sourceFile, targetPath))
            yield return holder;
    }

    private static IEnumerable<ITagPrefixHolder> GetHoldersInFile(IPsiSourceFile sourceFile, FileSystemPath targetPath)
    {
        throw new NotImplementedException();
    }

    private static IEnumerable<ITagPrefixHolder> GetRelevantHoldersBeforeFile(IPsiSourceFile sourceFile,
        FileSystemPath targetPath)
    {
        throw new NotImplementedException();
    }

    public IEnumerator MyEnumerator()
    {
        yield return "Hello";
        yield return "World";
    }


    private async Task<int> a()
    {
        int x = 0;

        // begin selection
        Action a = () =>
        {
            x += 1;
            Console.WriteLine(x);
        };
        a();
        // end selection

        a();

        return 1;
    }

    private async Task<int> b()
    {
        return await a();
    }
}

enum FileSystemPath
{
    Empty
}

internal interface IPsiSourceFile
{
    PrFile ToProjectFile();
}

internal class PrFile
{
    public FileSystemPath Location { get; set; }
}

internal interface ITagPrefixHolder
{
}