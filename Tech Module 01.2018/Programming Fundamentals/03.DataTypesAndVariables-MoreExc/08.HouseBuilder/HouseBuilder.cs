using System;

namespace _08.HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            int firstPrice = int.Parse(Console.ReadLine());
            int secondPrice = int.Parse(Console.ReadLine());
            long totalPrice = 0;

            if (firstPrice > sbyte.MaxValue)
            {
                totalPrice += 10l * firstPrice;
            }
            else
            {
                totalPrice += 4l * firstPrice;
            }
            if (secondPrice > sbyte.MaxValue)
            {
                totalPrice += 10l * secondPrice;
            }
            else
            {
                totalPrice += 4l * secondPrice;
            }
            Console.WriteLine(totalPrice);
        }
    }
}
