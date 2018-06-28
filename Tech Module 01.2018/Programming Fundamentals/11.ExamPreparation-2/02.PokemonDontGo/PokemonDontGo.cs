using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<long> pokemons = Console.ReadLine().Split().Select(long.Parse).ToList();
            long sum = 0;
            long currentValue = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    sum += pokemons[0];
                    currentValue = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (index >= pokemons.Count)
                {
                    sum += pokemons[pokemons.Count - 1];
                    currentValue = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    sum += pokemons[index];
                    currentValue = pokemons[index];
                    pokemons.RemoveAt(index);
                }
                ChangePokemonValues(pokemons, currentValue);
            }

            Console.WriteLine(sum);
        }

        static void ChangePokemonValues(List<long> pokemons, long currentValue)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= currentValue)
                {
                    pokemons[i] += currentValue;
                }
                else
                {
                    pokemons[i] -= currentValue;
                }
            }
        }
    }
}
