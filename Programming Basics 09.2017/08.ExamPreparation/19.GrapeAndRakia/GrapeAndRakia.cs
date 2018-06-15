using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kgPerSquareMeter = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grapes = area * kgPerSquareMeter - waste;
            double rakia = grapes * 0.45 / 7.5 * 9.8;
            double saleGrapes = grapes * 0.55 * 1.5;

            Console.WriteLine("{0:f2}", rakia);
            Console.WriteLine("{0:f2}", saleGrapes);
        }
    }
}
