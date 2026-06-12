// class

//Human human = new Human();

// introducing C# 9 = new(), = new(param1, param2)
//Human human = new();
Human human = new("Nadir", "Zamanov", 45);
Foo();
Human human1 = new(firstName:"Nadir", age:45, lastName:"Zamanov");
Human human2 = new()
{
    firstName = "Nadir",
    age = 46,
    lastName = "Zamanov"
};

void Foo()
{
    Human human = new("Nadir", "Zamanov", 45);
}

// const
// readonly
// Property