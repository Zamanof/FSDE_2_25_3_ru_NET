// C# Generics <=> C++ Templates
/*
    - Class
    - Struct
    - Method
    - Interface
    - Delegate
    - Collection
*/

Some<string> some = new();

//some.Foo();

some.Bar<int, string>(42, "Hello");
// Generic class with a type parameter T
class Some<T>where T : class , IEnumerable<char>
    //  where T: Это ограничение, которое указывает,
    //  каким должен быть T.
    //  where T: class
    //  Это означает, что T может быть любым классом,
    //  интерфейсом, делегатом или массивом,
    //  но не может быть значимым типом (struct)
    //  или примитивным типом (например, int, double).
    //  where T: IEnumerable<char>
    //  это ограничение, которое указывает,
    //  что T должен реализовывать интерфейс IEnumerable<char>.
    //  where T: new()
    //  Это ограничение, которое указывает,
    //  что T должен иметь открытый конструктор без параметров.
{
    public T Property { get; set; }
    public void Foo()
    {
        Console.WriteLine(Property.GetType());
    }

    // Generic method with type parameters T2 and T3
    public T2 Bar<T2, T3>(T2 value1, T3 value2)
    {
        Console.WriteLine(value1.GetType());
        Console.WriteLine(value2.GetType());
        return value1;

    }
}

class Other: Some<string>
{

}