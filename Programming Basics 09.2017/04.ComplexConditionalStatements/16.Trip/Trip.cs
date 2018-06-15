using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double price;
            string destination;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                Console.WriteLine("Somewhere in {0}", destination);
                if (season == "summer")
                {
                    price = budget * 0.3;                    
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = budget * 0.7;
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else if (budget > 100 && budget <= 1000 )
            {
                destination = "Balkans";
                Console.WriteLine("Somewhere in {0}", destination);
                if (season == "summer")
                {
                    price = budget * 0.4;
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else if (season == "winter")
                {
                    price = budget * 0.8;
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else
            {
                destination = "Europe";
                Console.WriteLine("Somewhere in {0}", destination);
                price = budget * 0.9;
                Console.WriteLine("Hotel - {0:F2}", price);
            }
        }
    }
}
