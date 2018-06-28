using System;
using System.Linq;

namespace _08.UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string[] order = Console.ReadLine().Split(' ').ToArray();

            while (order[0] != "done")
            {
                long orderedQuantity = long.Parse(order[1]);

                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == order[0] && i > quantities.Length - 1)
                    {
                        Console.WriteLine($"We do not have enough {products[i]}");
                    }
                    else if (products[i] == order[0] && quantities[i] >= orderedQuantity)
                    {
                        decimal totalPrice = prices[i] * orderedQuantity;
                        Console.WriteLine($"{products[i]} x {orderedQuantity} costs {totalPrice:f2}");
                        quantities[i] -= orderedQuantity;
                    }
                    else if (products[i] == order[0] && quantities[i] < orderedQuantity)
                    {
                        Console.WriteLine($"We do not have enough {products[i]}");
                    }
                }

                order = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
