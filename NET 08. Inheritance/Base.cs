/*
    sealed - "запечатанный" класс не может быть унаследован. 
*/
class Base
{
    public int Field1 { get; set; }
    private int filed2;

    public Base(int field1, int filed2)
    {
        Field1 = field1;
        this.filed2 = filed2;
        Console.WriteLine("Base Class Parametrized Constructor");
    }

    public Base()
        : this(0, 0)
    {
        Console.WriteLine("Base Class Default Constructor");
    }

    public void Show()
        => Console.WriteLine($" Base Show Field1 = {Field1}, Field2 = {filed2}");

    private void Foo()
    {
        Console.WriteLine("Base Private Foo");
    }

    protected void Bar()
    {
        Foo();
        Console.WriteLine("Base Protected Bar");
    }

}

