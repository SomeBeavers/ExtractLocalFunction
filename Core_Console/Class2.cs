namespace Core_Console;

public class Class2
{
    struct MyStruct
    {
        public int Num { get; }

        public MyStruct(int num)
        {
            Num = num;
        }

        public MyStruct GetParent()
        {
            return new(Num + 1);
        }
    }
    int test()
    {
        var lastNode = new MyStruct(0);
        while (lastNode is { Num: < 5 }) lastNode = lastNode.GetParent();
        return lastNode.Num;
    }

}