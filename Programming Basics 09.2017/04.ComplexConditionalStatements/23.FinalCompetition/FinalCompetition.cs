using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.FinalCompetition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double prize = 0.0;

            switch (place)
            {
                case "bulgaria":
                    prize = points * dancers;
                    if (season == "summer")
                    {
                        prize -= prize * 0.05;
                    }
                    else if (season == "winter")
                    {
                        prize -= prize * 0.08;
                    }
                    break;
                case "abroad":
                    prize = points * dancers * 1.5;
                    if (season == "summer")
                    {
                        prize -= prize * 0.1;
                    }
                    else if (season == "winter")
                    {
                        prize -= prize * 0.15;
                    }
                    break;
                default:
                    break;
            }

            double charity = prize * 0.75;
            double prizePerDancer = (prize - charity) / dancers;
            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}", prizePerDancer);
        }
    }
}
