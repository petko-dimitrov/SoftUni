using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string[]>> pokemons = new Dictionary<string, List<string[]>>();

            while (input != "wubbalubbadubdub")
            {
                if (!input.Contains("->"))
                {
                    if (pokemons.ContainsKey(input))
                    {
                        PrintCurrentPokemon(input, pokemons);
                    }
                    input = Console.ReadLine();
                    continue;
                }                

                else
                {
                    string[] pokemonInfo = input
                        .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = pokemonInfo[0];
                    string evolutionType = pokemonInfo[1];
                    string evolutionIndex = pokemonInfo[2];
                    string[] currentInfo = {evolutionType, evolutionIndex };
                    List<string[]> current = new List<string[]>();
                    current.Add(currentInfo);

                    if (!pokemons.ContainsKey(name))
                    {
                        pokemons.Add(name, current);
                    }

                    else 
                    {
                        pokemons[name].Add(currentInfo);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var pair in pokemon.Value.OrderByDescending(x => int.Parse(x[1])))
                {
                    Console.WriteLine($"{pair[0]} <-> {pair[1]}");
                }
            }
        }

        static void PrintCurrentPokemon(string input, Dictionary<string, List<string[]>> pokemons)
        {
            Console.WriteLine($"# {input}");
            foreach (var pair in pokemons[input])
            {
                Console.WriteLine($"{pair[0]} <-> {pair[1]}");
            }
        }
    }
}
