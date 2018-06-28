using System;
using System.Globalization;

namespace _05.SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal totalSum = 0;

            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysOfMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal orderPrice = daysOfMonth * capsulesCount * pricePerCapsule;
                totalSum += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
