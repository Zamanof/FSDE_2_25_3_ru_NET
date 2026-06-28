/*
Наследование — это один из принципов ООП, 
при котором дочерний класс получает функциональность родительского класса, 
благодаря чему расширяются его возможности. 
*/

/*
        C++                 Python                  C#

    Parent class        Super class             Base class

    Child class          Sub class             Derived class 
*/

//Base @base = new Base();

//Derived derived = new Derived("Salam", 10, 20);
//Derived derived1 = new Derived();

GrandDerived grandDerived = new GrandDerived();
//grandDerived.Bar();


/*
 Base class constructors:
    public Base() : this(0, 0)
    public Base(int field1, int filed2)

 Derived class constructors:
    public Derived() :this(string.Empty, 0, 0)
    public Derived(string someProperty, int field1, int field2)
        : base(field1, field2)

GrandDerived class constructors:
    public GrandDerived() : base("Hi", 49, 98)
    public GrandDerived(string someProperty, int field1, int field2) 
        : base(someProperty, field1, field2)
*/