using System;

namespace _17.SoftUniAirplane
{
    class SoftUniAirline
    {
        static void Main(string[] args)
        {
            int numberOfFlights = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;

            for (int i = 0; i < numberOfFlights; i++)
            {
                int adults = int.Parse(Console.ReadLine());
                decimal adultsPrice = decimal.Parse(Console.ReadLine());
                int children = int.Parse(Console.ReadLine());
                decimal childrenPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = adults * adultsPrice + children * childrenPrice;
                decimal expenses = flightDuration * fuelConsumption * fuelPrice;
                decimal profit = income - expenses;
                totalProfit += profit;
                
                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }
            }

            Console.WriteLine($"Overall profit -> {totalProfit:f3}$.");
            Console.WriteLine($"Average profit -> {totalProfit/numberOfFlights:f3}$.");
        }
    }
}
