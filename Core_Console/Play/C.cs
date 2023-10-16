class C : I
{
    void I.Foo<T>(T x) // T has implicit constraint IComparable
    {
        int c = x.CompareTo(null); // Extract Method from this line
        Console.WriteLine(c);
    }
}