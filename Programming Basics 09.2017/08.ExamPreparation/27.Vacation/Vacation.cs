using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0.0;
            string location = "";
            string acommodation = "";

            switch (season)
            {
                case "Summer":
                    location = "Alaska";
                    if (budget <= 1000)
                    {
                        price = budget * 0.65;
                        acommodation = "Camp";
                    }
                    else if (budget <= 3000)
                    {
                        price = budget * 0.8;
                        acommodation = "Hut";
                    }
                    else
                    {
                        price = budget * 0.9;
                        acommodation = "Hotel";
                    }
                    break;
                case "Winter":
                    location = "Morocco";
                    if (budget <= 1000)
                    {
                        price = budget * 0.45;
                        acommodation = "Camp";
                    }
                    else if (budget <= 3000)
                    {
                        price = budget * 0.6;
                        acommodation = "Hut";
                    }
                    else
                    {
                        price = budget * 0.9;
                        acommodation = "Hotel";
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0} - {1} - {2:f2}",location, acommodation, price);
        }
    }
}
