namespace Core_Console.Partials;

public partial class Partial1<T>
{
    public partial void PartialMethod(int[] parameters);

    private void CallAnotherMethod(T t)
    {
        throw new NotImplementedException();
    }

    public partial void PartialMethod(A[] parameters = null);
}