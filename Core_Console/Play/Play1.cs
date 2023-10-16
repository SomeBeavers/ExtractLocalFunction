namespace Core_Console.Play;

public class MyObjectRepository
{
    private readonly string _someOtherString = "";
    private readonly MyContext _context = new MyContext();

    public void Add(MyObject myobj)
    {
        // TODO: refactor these 3 lines
        myobj.Foo = 123;
        myobj.Bar = DateTime.UtcNow;
        myobj.Baz = _someOtherString;

        _context.MyObjects.Add(myobj);
        _context.SaveChanges();
    }
}

public class MyObject
{
    public int Foo { get; set; }
    public DateTime Bar { get; set; }
    public string Baz { get; set; }
}

internal class MyContext
{
    public List<MyObject> MyObjects { get; set; }

    public void SaveChanges()
    {
        throw new NotImplementedException();
    }
}

class C1
{
    public static readonly int Y = 7;
}

class ContainingClass
{
    public void JB1()
    {
        using (null) Console.WriteLine();
        bool s = Console.ReadLine() as bool;

        var stringVar = s ? "" : "1";

        var anon = new
        {
            Str = string.Empty,
            Num = default(int)
        };

        var DTO = new DTO
        {
            str = anon.Str,
            @int = anon.Num
        };
    }
}

class DTO
{
    public string str;
    public int @int;
}

class C2
{
    private C1 myC1;

    public C2()
    {
        var y = C1.Y;
        var x = new C1();
        myC1 = x;
    }

    public float Test()
    {
        const float a = 1;
        const float b = 2;

        // extract begin 
        float x = 10;
        float t = a + x * (b - a);
        return t;
        // extract end 
    }
}

class Program1
{
    static void Main1()
    {
        // <extract>
        var a = Console.ReadLine();
        if (a == null) return;
        var b = Console.ReadLine();
        if (b == null) return;
        // </extract>

        var t = (b, a, test: 5);

        Console.WriteLine("{0}, {1}", a, b);
    }
}