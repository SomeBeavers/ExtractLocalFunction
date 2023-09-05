namespace Core_Console;

public class Generic<T> where T : class
{
    public T GetT<U>(U u) where U : T, new()
    {
        List<T> list = new List<T>();

        if (u == null)
        {
            throw new ArgumentNullException();
        }

        return new U();
    }
}