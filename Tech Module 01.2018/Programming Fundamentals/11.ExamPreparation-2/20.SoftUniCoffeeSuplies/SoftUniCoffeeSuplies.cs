using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _20.SoftUniCoffeeSuplies
{
    class SoftUniCoffeeSuplies
    {
        static void Main(string[] args)
        {
            string[] delimiters = Console.ReadLine().Split();

            string firstDelimiter = Regex.Escape(delimiters[0]);
            string secondDelimiter = Regex.Escape(delimiters[1]);
            string firstPattern = $@"(.+)({firstDelimiter})(.+)";
            string secondPattern = $@"(.+)({secondDelimiter})(.+)";
            Dictionary<string, string> people = new Dictionary<string, string>();
            Dictionary<string, long> coffees = new Dictionary<string, long>();

            string coffeData = Console.ReadLine();

            while (coffeData != "end of info")
            {
                if (Regex.IsMatch(coffeData, firstPattern))
                {
                    var match = Regex.Match(coffeData, firstPattern);
                    string personName = match.Groups["1"].Value.ToString();
                    string coffeeType = match.Groups["3"].Value.ToString();
                    people.Add(personName, coffeeType);

                    if (!coffees.ContainsKey(coffeeType))
                    {
                        coffees.Add(coffeeType, 0);
                    }
                }

                else if (Regex.IsMatch(coffeData, secondPattern))
                {
                    var match = Regex.Match(coffeData, secondPattern);
                    string coffeeType = match.Groups["1"].Value.ToString();
                    long quantity = long.Parse(match.Groups["3"].Value.ToString());

                    if (!coffees.ContainsKey(coffeeType))
                    {
                        coffees.Add(coffeeType, quantity);
                    }
                    else
                    {
                        coffees[coffeeType] += quantity;
                    }
                }

                coffeData = Console.ReadLine();
            }

            foreach (var coffee in coffees)
            {
                if (coffee.Value <= 0)
                {
                    Console.WriteLine($"Out of {coffee.Key}");
                }
            }

            string drinkText = Console.ReadLine();

            while (drinkText != "end of week")
            {
                string[] drinkInfo = drinkText.Split();
                string personName = drinkInfo[0];
                long count = long.Parse(drinkInfo[1]);
                string coffeeType = people[personName];

                coffees[coffeeType] -= count;

                if (coffees[coffeeType] <= 0)
                {
                    Console.WriteLine($"Out of {coffeeType}");
                }

                drinkText = Console.ReadLine();
            }

            List<string> remainingCoffees = new List<string>();

            Console.WriteLine("Coffee Left:");
            foreach (var coffee in coffees.Where(x => x.Value > 0)
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{coffee.Key} {coffee.Value}");
                remainingCoffees.Add(coffee.Key);
            }

            Console.WriteLine("For:");
            foreach (var person in people.Where(x => remainingCoffees.Contains(x.Value))
                .OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{person.Key} {person.Value}");
            }
        }
    }
}
