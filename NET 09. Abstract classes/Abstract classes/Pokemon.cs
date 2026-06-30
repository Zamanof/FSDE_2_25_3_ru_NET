abstract class Pokemon
{
    public string Name { get; set; }
    public int Level { get; set; } = 0;

    protected Pokemon(string name)
    {
        Name = name;
    }

    public abstract void Attack();
    public abstract void Sound();

    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level}!");
    }
}
