// GrandDerived < Derived < Base
class GrandDerived : Derived
{
    public GrandDerived()
        : base("Hi", 49, 98)
    {
        Console.WriteLine("GrandDerived Class Default Constructor");
    }

    public GrandDerived(string someProperty, int field1, int field2) 
        : base(someProperty, field1, field2)
    {
        Console.WriteLine("GrandDerived Class Parametrized Constructor");
    }

    public void GrandDerivedBar() 
    {
        base.Bar();
        Bar();
    }
}

