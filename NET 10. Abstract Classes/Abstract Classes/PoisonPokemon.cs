// Abstract classes

abstract class PoisonPokemon : Pokemon
{
    protected PoisonPokemon(string name)
        : base(name)
    { }
    public abstract void PoisonAttack();
}

