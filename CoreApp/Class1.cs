namespace CoreApp;

public class Class1
{
    public void Test()
    {
        Console.WriteLine("");
    }

    public async Task TestAsync()
    {
        await using IAsyncDisposable asyncDisposableNumberOne = null,
            asyncDisposableNumberTwo = null;
        await Task.Delay(10);
        Console.WriteLine(asyncDisposableNumberOne);
        Console.WriteLine(asyncDisposableNumberTwo);
        Console.WriteLine("Hello, World!");
    }
}