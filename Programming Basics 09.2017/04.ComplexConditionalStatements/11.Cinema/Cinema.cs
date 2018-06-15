using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int places = rows * columns;
            double profit;
            if (type == "premiere")
            {
                profit = places * 12;
                Console.WriteLine(Math.Round(profit, 2));
            }
            else if (type == "normal")
            {
                profit = places * 7.5;
                Console.WriteLine(Math.Round(profit, 2));
            }
            else if (type == "discount")
            {
                profit = places * 5;
                Console.WriteLine(Math.Round(profit, 2));
            }
        }
    }
}
