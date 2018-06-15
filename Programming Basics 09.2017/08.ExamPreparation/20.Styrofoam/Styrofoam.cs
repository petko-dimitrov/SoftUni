using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double foamPerPackage = double.Parse(Console.ReadLine());
            double pricePerPackage = double.Parse(Console.ReadLine());

            double packagesNeeded = Math.Ceiling((area - windows * 2.4) * 1.1 / foamPerPackage);
            double moneySpent = packagesNeeded * pricePerPackage;

            if (moneySpent <= budget)
            {
                Console.WriteLine("Spent: {0:f2}", moneySpent);
                Console.WriteLine("Left: {0:f2}", budget - moneySpent);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", moneySpent - budget);
            }
        }
    }
}
