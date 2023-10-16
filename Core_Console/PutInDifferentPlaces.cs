using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Core_Console;

public class PutInDifferentPlaces<T>
{
    public string Name
    {
        get => _name;
        set { _name = value; }
    }

    public List<T>? List;
    private string _name;

    public PutInDifferentPlaces(int count)
    {
        List = new List<T>();
        Count = count;

        List.Where(x => x != null);
    }

    public int Count { get; set; }

    public void Test(Person person)
    {
        Console.WriteLine(person.Name);
        var achterNaam = "Doe";

        person.Name = achterNaam;

        var list = new List<string>();
        list.Add(person.Name);
    }
}

public record UsePutInDifferentPlaces(string Name = "")
{
    public void Test(MyEnum myEnum, bool condition, List<Person> list)
    {
        switch (condition)
        {
            case true:
            case false:
                Console.WriteLine(myEnum);
                break;
        }
        // comment 1

        switch (myEnum)
        {
            case MyEnum.A:
                Console.WriteLine(myEnum);
                NewFunction();

                void NewFunction()
                {
                    Console.WriteLine(myEnum);
                }

                break;
            case MyEnum.B:
                break;
            case MyEnum.C:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(myEnum), myEnum, null);
        }

        list.Where(predicate: x => x.Name.Length != 0);

        // comment 2
    }
}

public enum MyEnum
{
    A,
    B,
    C
}

public class Person
{
    public string? Name { get; set; }
}

public static class StaticClass
{
    public static Color GetEntityColorAbs(this string name)
    {
        if (name == "blue")
        {
            return Color.Blue;
        }
        else
            return Color.Red;

        return Color.Green;
    }
}