// class

//Human human = new Human();

// introducing C# 9 = new(), = new(param1, param2)
//Human human = new();

/*
    internal - class доступен только в assembly где был обявлен
    public   - class доступен в любых assembly 
*/
partial class Human
{
    /*
    public
    Доступен отовсюду.
    Класс, метод, свойство или поле можно использовать из любого места программы
    и из любых других проектов, если есть ссылка на сборку.

    private
    Доступен только внутри того класса, в котором объявлен.
    Из других классов получить к нему доступ нельзя.

    protected
    Доступен внутри текущего класса и во всех классах-наследниках.
    Из обычных объектов, не являющихся наследниками, доступ невозможен.

    internal
    Доступен только внутри текущей сборки (проекта).
    Из других проектов получить доступ нельзя, даже если они подключены.

    protected internal
    Доступен:
    - внутри текущей сборки;
    - а также в классах-наследниках, даже если они находятся в другой сборке.

    private protected
    Доступен:
    - внутри текущего класса;
    - в классах-наследниках;
    - только если они находятся в той же самой сборке (проекте).

    Если наследник находится в другой сборке,
    доступ к private protected членам невозможен.

    Проще говоря:
    public              -> доступ отовсюду
    private             -> только внутри своего класса
    protected           -> внутри класса и его наследников
    internal            -> только внутри текущего проекта (сборки)
    protected internal  -> внутри текущего проекта + в наследниках из других проектов
    private protected   -> внутри текущего проекта + только в наследниках
*/
    public string firstName;
    public string lastName;
    public int age;

    readonly string bloodType;
    public const double PI = 3.14;

    public static int count;

    static Human()
    {
        count = 0;
    }
    public Human(
        string firstName, 
        string lastName, 
        int age, 
        string bloodType)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.bloodType = bloodType;
        count++;
    }

    public Human(
        string firstName,
        string lastName)
        :this(firstName, lastName, 0, "0")
    {
        count++;
    }

    public Human()
        :this(string.Empty, string.Empty, 0, "0")
    {
        count++;
    }

    public static int getCount() => count;

    public void ShowInfo()
    {
        Console.WriteLine(@$"
Name:           {firstName}
Surname:        {lastName}
Age:            {age}
Blood Type:     {bloodType}
");
    }

    public string GetInfo()
    {
        return @$"
Name:           {firstName}
Surname:        {lastName}
Age:            {age}
Blood Type:     {bloodType}
";
    }

    //    public override string ToString()
    //    {
    //        return @$"
    //Name:           {firstName}
    //Surname:        {lastName}
    //Age:            {age}
    //Blood Type:     {bloodType}
    //";
    //    }

    public int getAge() => age;
    public void setAge(int value) => age = value;
    public override string ToString()=>@$"
Name:           {firstName}
Surname:        {lastName}
Age:            {age}
Blood Type:     {bloodType}
";

    // Finalizer - называть этот метод Destructor-ом это грубая ошибка
    ~Human()
    {
        Console.WriteLine("Finalizer");
    }
}

