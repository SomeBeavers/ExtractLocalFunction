namespace Core_Console;

public class PutInDifferentPlaces
{
    public int Count { get; set; }

    public void Test(Person person)
    {
        Console.WriteLine(person.Name);
        string achterNaam = "Doe";

        person.Name = achterNaam;

        var list = new List<string>();
        list.Add(person.Name);
    }
}

public record UsePutInDifferentPlaces(string Name = "")
{

}

public class Person
{
    public string? Name { get; set; }
}