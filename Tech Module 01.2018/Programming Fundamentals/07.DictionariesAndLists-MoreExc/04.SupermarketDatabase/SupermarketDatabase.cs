using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            while (input[0] != "stocked")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                Dictionary<double, int> currentProduct = new Dictionary<double, int>();
                currentProduct.Add(price, quantity);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, currentProduct);
                }
                else
                {
                    products[product].Add(price, quantity);
                }

                input = Console.ReadLine().Split();
            }

            double totalSum = 0;

            foreach (var product in products)
            {
                double sum = product.Value.Keys.Last() * product.Value.Values.Sum();
                totalSum += sum;

                Console.WriteLine($"{product.Key}: ${product.Value.Keys.Last():F2} * {product.Value.Values.Sum()}" +
                    $" = ${sum:F2}");
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${totalSum:F2}");
        }
    }
}
