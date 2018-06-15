using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double money = 0.0;

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kmPerMonth <= 5000)
                    {
                        money = 0.75 * kmPerMonth * 4;
                    }
                    else if (kmPerMonth <= 10000 )
                    {
                        money = 0.95 * kmPerMonth * 4;
                    }
                    else
                    {
                        money = 1.45 * kmPerMonth * 4;
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        money = 0.9 * kmPerMonth * 4;
                    }
                    else if (kmPerMonth <= 10000)
                    {
                        money = 1.1 * kmPerMonth * 4;
                    }
                    else
                    {
                        money = 1.45 * kmPerMonth * 4;
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        money = 1.05 * kmPerMonth * 4;
                    }
                    else if (kmPerMonth <= 10000)
                    {
                        money = 1.25 * kmPerMonth * 4;
                    }
                    else
                    {
                        money = 1.45 * kmPerMonth * 4;
                    }
                    break;
                default:
                    break;
            }

            money *= 0.9;
            Console.WriteLine("{0:f2}", money);
        }
    }
}
