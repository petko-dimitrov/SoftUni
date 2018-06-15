using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());
            double bus = 0.0;
            double truck = 0.0;
            double train = 0.0;
            double totalTonnage = 0.0;

            for (int i = 0; i < loads; i++)
            {
                int tonnage = int.Parse(Console.ReadLine());
                totalTonnage += tonnage;
                if (tonnage < 4)
                {
                    bus += tonnage;
                }
                else if (tonnage >=4 && tonnage < 12)
                {
                    truck += tonnage;
                }
                else
                {
                    train += tonnage;
                }
            }

            double avgPrice = (bus * 200 + truck * 175 + train * 120) / totalTonnage;
            bus = bus / totalTonnage * 100;
            truck = truck / totalTonnage * 100;
            train = train / totalTonnage * 100;
            Console.WriteLine("{0:f2}", avgPrice);
            Console.WriteLine("{0:f2}%", bus);
            Console.WriteLine("{0:f2}%", truck);
            Console.WriteLine("{0:f2}%", train);
        }
    }
}
