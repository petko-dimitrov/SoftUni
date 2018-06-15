using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grapes = x * y * 0.4;
            double wine = grapes / 2.5;
            if (wine < z)
            {
                double wineNeeded = Math.Floor(z - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", wineNeeded);
            }
            else
            {
                double wineLeft = wine - z;
                double litersPerWorker = wineLeft / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(wineLeft), Math.Ceiling(litersPerWorker));
            }
        }
    }
}
