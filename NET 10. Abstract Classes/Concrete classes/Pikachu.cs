class Pikachu : ElectricPokemon
{
    public Pikachu(string name) 
        : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Pikachu->{Name} attacked");
    }

    public override void ElectrickAttack()
    {
        Console.WriteLine($"Pikachu->{Name} electric attacked");
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} say: Pika Pika");
    }

    public void Thunderbolt()
    {
        Console.WriteLine($"Pikachu->{Name} used Thunderbolt");
    }
}
