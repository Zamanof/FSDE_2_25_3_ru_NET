// Абстрактные классы - отношение is (является)
// от абстрактных классов мы наследуемся и реализуем их методы.
// В C# мы можем наследоваться только от одного класса


// Интерфейсы - отношение can (может) (can do something).
// Это умение , которое может быть реализовано в классе.
// Интерфейсы мы реализуем в классе,
// и можем реализовать несколько интерфейсов в одном классе.

// Интерфейсы - это контракт, который мы должны реализовать (implementation) в классе.

// Несколько правил по интерфейсам:
// 1. Интерфейсы не могут содержать поля (fields). Но могут содержать свойства (properties).
// 2. Интерфейсы не могут содержать конструкторы (constructors).
// 3. В интерфейсах все методы и свойства по умолчанию public и abstract.
// Мы не можем использовать модификаторы доступа (access modifiers) в интерфейсах.

// Интерфейсная ссылка (interface reference) - это ссылка на объект, который реализует интерфейс.
IWalkable walkable = new Student() { FirstName = "John", LastName = "Doe", Age = 20 };

//Bar(walkable);
//Bar(new Cat());
//Bar(new Student() { FirstName = "Salam", LastName = "Salamzade", Age = 25 });
//Foo(new Cat());
//Foo(new Student() { FirstName = "Salam", LastName = "Salamzade", Age = 25 });
//Foo(new AI());

SomeMethod(new Student() { FirstName = "Salam", LastName = "Salamzade", Age = 25 });
//SomeMethod(new Cat());

void Foo(IThinkable thinker)
{
    thinker.Think();
}

void Bar(IWalkable walker)
{
    walker.Walk();
}

void SomeMethod(IHomoSapiens homoSapiens)
{
    homoSapiens.Walk();
    homoSapiens.Think();
}

abstract class Human
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
}

interface IWalkable
{
    void Walk();
}

interface IThinkable
{
    void Think();
}

interface IHomoSapiens : IWalkable, IThinkable
{ }

class Student : Human, IHomoSapiens
{
    
    public void Walk()
    {
        Console.WriteLine($"{FirstName} {LastName} is walking like Human.");
    }
    public void Think()
    {
        Console.WriteLine($"{FirstName} {LastName} is thinking like Human.");
    }
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {FirstName} {LastName}. I am {Age} years old.");
    }
}

class AI: IThinkable
{
    public void Think()
    {
        Console.WriteLine($"AI try think like Human.");
    }
}

class Cat : IWalkable, IThinkable
{
    public void Think()
    {
        Console.WriteLine("I think about Еда и спать и играть. А все люди мои рабы");
    }

    public void Walk()
    {
        Console.WriteLine($"Cat is walking like Cat.");
    }
}
