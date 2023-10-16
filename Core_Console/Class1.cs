using System.Collections;
using System.Collections.Generic;

namespace Core_Console;

public class Class1
{
    public void TestMethod()
    {
        var result = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }

            result.Add(i);
        }
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


    public void Test(List<int> list, bool b, object input)
    {
        Console.WriteLine("Hello, World!");
        int t = 1;

        Console.WriteLine(t);

        try
        {
            for (int i = 0; i < list.Count; i++)
            {
                foreach (var s in list)
                {
                    var ints = new List<int>() { list.Count };
                }

                if (b)
                {

                    var a = 1;
                    var reversed1 = 1;
                    var reversed2 = 1;
                    var reversed3 = 1;
                    var reversed4 = 1;
                    var reversed5 = 1;
                    var reversed6 = 1;
     
                    Console.WriteLine(reversed1);
                    Console.WriteLine(reversed2);
                    Console.WriteLine(reversed3);
                    Console.WriteLine(reversed4);
                    Console.WriteLine(reversed5);
                    Console.WriteLine(reversed6);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Test2(List<int> list, bool b, object input)
    {
        Console.WriteLine("Hello, World!");
        int t = 1;

        Console.WriteLine(t);

        try
        {
            for (int i = 0; i < list.Count; i++)
            {
                foreach (var s in list)
                {
                    var ints = new List<int>() { list.Count };
                }

                if (b)
                {

                    var a = 1;
                    var reversed1 = 1;
                    var reversed2 = 1;
                    var reversed3 = 1;
                    var reversed4 = 1;
                    var reversed5 = 1;
                    var reversed6 = 1;
 
                    Console.WriteLine(reversed1);
                    Console.WriteLine(reversed2);
                    Console.WriteLine(reversed3);
                    Console.WriteLine(reversed4);
                    Console.WriteLine(reversed5);
                    Console.WriteLine(reversed6);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}