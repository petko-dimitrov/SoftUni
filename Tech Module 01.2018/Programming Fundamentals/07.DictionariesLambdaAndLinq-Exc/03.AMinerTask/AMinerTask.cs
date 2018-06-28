using System;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQuantities = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            int quantity = 0;

            while (resource != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (resourceQuantities.ContainsKey(resource))
                {
                    resourceQuantities[resource] += quantity;
                }
                else
                {
                    resourceQuantities.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }

            foreach (var quant in resourceQuantities)
            {
                Console.WriteLine($"{quant.Key} -> {quant.Value}");
            }
        }
    }
}
