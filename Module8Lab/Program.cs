public class Pokemon {
    //attributes - variables that hold values
    //about a pokemon, characteristics of Pokemon
    public int Id {get; set;}
    public string? Name {get; set;}

    public string? Type {get; set;}

    public int Level {get; set;}

} //end pokemon class

// Pokemon LINQ Lab Class contains the Main method
// where we will create Pokemon objects
//first method will be called when program runs

public class PokemonLINQLab
{
    public static void Main()
    {
        // Sample data: list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15},
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36},
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10},
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22},
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25}
        };

        //linq query: find pokemon ready to evolve
        //level 16 for first evolution

        var readyToEvolve = from p in pokemons 
        where p.Level >= 16 
        orderby p.Level 
        select p;


        //execute the query and display the results
        Console.WriteLine("Pokemon ready to evolve:");
        foreach (var p in readyToEvolve)
        {
            Console.WriteLine($"{p.Name}, Type: {p.Type} (Level {p.Level}) is ready to evolve!");
        }
    }
}
