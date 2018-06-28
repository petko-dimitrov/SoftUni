using System;
using System.Linq;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string productName = Console.ReadLine();

            while (productName != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == productName)
                    {
                        Console.WriteLine($"{productName} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }

                productName = Console.ReadLine();
            }
        }
    }
}
