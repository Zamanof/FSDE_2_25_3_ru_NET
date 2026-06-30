class Derived : Base 
{
    public string SomeProperty { get; set; }
    public Derived()
        :this(string.Empty, 0, 0)
    {
        Console.WriteLine("Derived Class Default Constructor");
    }

    public Derived(string someProperty, int field1, int field2)
        : base(field1, field2)
    {
        SomeProperty = someProperty;
        Console.WriteLine("Derived Class Parametrized Constructor");
    }

    public void BarDerived()
    {
        Bar();
        Console.WriteLine($" Derived Show SomeProperty = {SomeProperty}");
    }
    // 
    public new void Bar()
    {
        Console.WriteLine("Derived Public Bar");
    }
}

