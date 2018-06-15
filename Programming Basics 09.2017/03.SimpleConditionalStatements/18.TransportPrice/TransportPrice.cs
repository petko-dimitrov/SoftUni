using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string period = Console.ReadLine();
            double cheapestPrice = 0.0;
            if (n < 20)
            {
                if (period == "day")
                {
                    cheapestPrice = n * 0.79 + 0.7;
                }
                else if (period == "night")
                {
                    cheapestPrice = n * 0.9 + 0.7;
                }
            }
            else if (n >= 20 && n < 100)
            {
                cheapestPrice = n * 0.09;
            }
            else
            {
                cheapestPrice = n * 0.06;
            }
            Console.WriteLine(cheapestPrice);
        }
    }
}
