namespace Multi;

public class Multi1
{
    public void Test(int t)
    {
#if NET7_0
        Console.WriteLine(t);
#else
        Console.WriteLine(t);
#endif

    }
}