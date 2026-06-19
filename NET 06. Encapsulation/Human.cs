// Encapsulation

class Human
{
    // properties
    // auto property
    public string FirstName { get; set; }
    //public string get_FirstName() => "Salam";
    //public void set_FirstName(string value) => value = "45";
    public string LastName { private get; set; }

    

    private int age;

    public Human(string firstName, string lastName, int age, int height)
    {
        FirstName = firstName;
        LastName = lastName;
        this.age = age;
        Height = height;
    }

    public void setAge(int value)
    {
        if (value < 0)
            throw new ArgumentException("Age must be positive");
        age = value;
    }


    public int getAge()
        => age;

    // full propert
    private int height;

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be positive");
            height = value;
        }
    }

}