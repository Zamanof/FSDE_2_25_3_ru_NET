// class
//object obj = 25;
//Console.WriteLine(obj.GetType());
//Human human = new Human();

// introducing C# 9 = new(), = new(param1, param2)
//Human human = new();

Console.WriteLine(Human.getCount());
Console.WriteLine(Human.PI);
Human human = new("Nadir", "Zamanov", 45, "A+");
Foo();
Human human1 = new(firstName: "Nadir", age: 45, lastName: "Zamanov", bloodType: "A+");
Human human2 = new()
{
    firstName = "Nadir",
    age = 46,
    lastName = "Zamanov"
};
//human.ShowInfo();
//Console.WriteLine(human.GetInfo()); 
Console.WriteLine(human);
Console.WriteLine(Human.getCount());
Dog dog = new("Baskervile", 3, 256);
void Foo()
{
    Human human = new("Nadir", "Zamanov", 45, "A+");
}

// const
// readonly
// Property