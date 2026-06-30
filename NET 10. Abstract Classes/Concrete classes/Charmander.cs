class Charmander : FirePokemon
{
    public Charmander(string name)
        : base(name)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"Charmander->{Name} attacked");
    }
    public override void FireAttack()
    {
        Console.WriteLine($"Charmander->{Name} fire attacked");
    }
    public override void Sound()
    {
        Console.WriteLine($"{Name} say: Char Char");
    }
    public void Flamethrower()
    {
        Console.WriteLine($"Charmander->{Name} used Flamethrower");
    }
}
