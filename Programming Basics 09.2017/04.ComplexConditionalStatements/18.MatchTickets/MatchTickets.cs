using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            double transport = 0.0;
            double tickets = 0.0;
            double difference = 0.0;
            if (people >= 1 && people <= 4)
            {
                transport = 0.75 * budget;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = 0.6 * budget;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = 0.5 * budget;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = 0.4 * budget;
            }
            else if (people >= 50)
            {
                transport = 0.25 * budget;
            }
            if (category == "vip")
            {
                tickets = people * 499.99;
            }
            else
            {
                tickets = people * 249.99;
            }
            difference = budget - (tickets + transport);
            if (difference >= 0)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left." , difference);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(difference));
            }
        }
    }
}
