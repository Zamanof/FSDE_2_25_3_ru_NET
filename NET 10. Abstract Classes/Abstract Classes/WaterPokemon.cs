// Abstract classes

abstract class WaterPokemon : Pokemon
{
    protected WaterPokemon(string name)
        : base(name)
    { }
    public abstract void WaterAttack();
}

