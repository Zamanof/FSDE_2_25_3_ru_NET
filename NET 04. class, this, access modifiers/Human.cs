// class

//Human human = new Human();

// introducing C# 9 = new(), = new(param1, param2)
//Human human = new();

/*
    internal - class доступен только в assembly где был обявлен
    public   - class доступен в любых assembly 
*/
class Human
{
    /*
     access modifiers:
        1. public
        2. private
        3. protected
        4. internal
        5. protected internal
        6. private protected
    */
    public string firstName;
    public string lastName;
    public int age;

    public Human(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public Human()
    {
        firstName = string.Empty;
        lastName = string.Empty;
        age = 0;
    }
    // Finalizer - называть этот метод Destructor-ом это грубая ошибка
    ~Human()
    {
        Console.WriteLine("Finalizer");
    }
}
