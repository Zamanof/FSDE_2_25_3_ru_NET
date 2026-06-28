class Base
{
    public string Field1 { get; set; } = "Base Field1";
    public virtual void Show()
    {
        Console.WriteLine("Base Class Show()");
    }
}
