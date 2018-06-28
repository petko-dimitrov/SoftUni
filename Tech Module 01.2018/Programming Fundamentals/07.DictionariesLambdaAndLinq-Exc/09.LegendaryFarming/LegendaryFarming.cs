using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            string[] harvest = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);
            bool shadowmourneObtained = false;
            bool valanyrObtained = false;
            bool dragonwrathObtained = false;

            while (!shadowmourneObtained && !valanyrObtained && !dragonwrathObtained)
            {
                for (int i = 0; i < harvest.Length; i+=2)
                {
                    string material = harvest[i + 1];
                    int quantity = int.Parse(harvest[i]);
                    if (!materials.ContainsKey(material))
                    {
                        materials.Add(material, quantity);
                    }
                    else
                    {
                        materials[material] += quantity;
                    }
                    if (materials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        materials["shards"] -= 250;
                        shadowmourneObtained = true;
                        break;
                    }
                    else if (materials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        materials["fragments"] -= 250;
                        valanyrObtained = true;
                        break;
                    }
                    else if (materials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        materials["motes"] -= 250;
                        dragonwrathObtained = true;
                        break;
                    }
                }

                if (!shadowmourneObtained && !valanyrObtained && !dragonwrathObtained)
                {
                    harvest = Console.ReadLine().ToLower().Split();
                }
            }

            foreach (var pair in materials
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes"))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in materials
                .OrderBy(x => x.Key)
                .Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes"))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
