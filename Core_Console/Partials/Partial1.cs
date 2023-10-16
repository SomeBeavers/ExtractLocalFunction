namespace Core_Console.Partials;

public partial class Partial1<T>
{
    public partial void PartialMethod(A[] parameters = null)
    {
        T t = default(T);

        foreach (var parameter in parameters)
        {
            if (parameter != null)
            {
                Console.WriteLine(parameter);

                A[] anotherParameters = new[] { parameter };
            }
            else
            {
                CallAnotherMethod(t);
            }
        }


        if (t != null)
        {
            CallAnotherMethod(t);
        }
    }
}

public class A
{
}