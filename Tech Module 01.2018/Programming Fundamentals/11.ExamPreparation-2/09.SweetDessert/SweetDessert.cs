using System;

namespace _09.SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal ammountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuest = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal cashForAPortion = 2 * bananaPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            decimal portions = Math.Ceiling(numberOfGuest / 6m);
            decimal totalCashNeeded = cashForAPortion * portions;

            if (ammountOfCash < totalCashNeeded)
            {
                decimal cashNeeeded = totalCashNeeded - ammountOfCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {cashNeeeded:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCashNeeded:f2}lv.");
            }
        }
    }
}
