// Abstract classes

abstract class Pokemon
{
    public string Name { get; set; }
    public int Level = 0;

    protected Pokemon(string name)
    {
        Name = name;
    }

    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} Level up to {Level}");
    }

    public abstract void Sound();
    public abstract void Attack();

}

