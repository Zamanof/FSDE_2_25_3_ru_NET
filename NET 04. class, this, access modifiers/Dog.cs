// Primary constructor - new in C# 12
class Dog(string name, int age, double price)
{
    public override string ToString()
            => $"{name}: {age} year -> {price}";
}

//class Dog
//{
//    string name;
//    int age;
//    double price;

//    public Dog(string name, int age, double price)
//    {
//        this.name = name;
//        this.age = age;
//        this.price = price;
//    }

//    public override string ToString()
//        => $"{name}: {age} year -> {price}";
//}
