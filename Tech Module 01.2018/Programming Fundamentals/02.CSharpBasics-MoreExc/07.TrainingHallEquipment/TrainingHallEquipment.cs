using System;

namespace _07.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < items; i++)
            {
                string itemName = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount == 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                totalPrice += itemCount * price;
            }

            Console.WriteLine($"Subtotal: ${totalPrice:f2}");
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Money left: ${(budget - totalPrice):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(totalPrice - budget):f2} more.");
            }
        }
    }
}
