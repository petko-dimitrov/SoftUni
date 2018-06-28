using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                Dictionary<string, long> currentCity = new Dictionary<string, long>();
                currentCity.Add(input[0], long.Parse(input[2]));

                if (!countries.ContainsKey(input[1]))
                {
                    countries.Add(input[1], currentCity);
                }
                else
                {
                    countries[input[1]].Add(input[0], long.Parse(input[2]));
                }

                input = Console.ReadLine().Split('|');
            }

            foreach (var country in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
