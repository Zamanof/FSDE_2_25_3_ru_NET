// Abstract classes
// Отношение is (является) - наследование
// (Означает принадлежность к тому или иному классу)
// Student is a Person, Cat is an Animal, Dog is an Animal, etc.


Pikachu pikachu = new Pikachu("Pikacha");
Charmander charmander = new Charmander("Charmanderilla");
// Ссылка на абстрактный класс
Pokemon pokemon = new Pikachu("Pikachu");

Pokemon[] pokemons = [ 
    pikachu, 
    charmander, 
    new Pikachu("PimbolDon"), pokemon
    ];
FirePokemon[] firePokemons = [
    charmander, 
    new Charmander("Charm"), 
    new Charmander("ASCII")
    ];

//foreach (var p in pokemons)
//{
//    p.Sound();
//}

//Figth(pikachu, charmander);
//FirePokemonsGym(charmander);
//FirePokemonsGym(charmander);
//FirePokemonsGym(firePokemons[2]);

(pokemons[0] as Pikachu)?.Thunderbolt();

void Figth(Pokemon p1, Pokemon p2)
{
    Console.WriteLine($"Fight between {p1.Name} and {p2.Name}");
    p1.Attack();
    p2.Attack();
}

void FirePokemonsGym(FirePokemon pokemon)
{
    pokemon.LevelUp();
}

