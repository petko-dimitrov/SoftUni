using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.HousePainting
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double walls = ((x * x * 2) - (1.2 * 2)) + ((2 * x * y) - (2 * 1.5 * 1.5));
            double roof = (2 * x * y) + x * h;
            double greenPaint = walls / 3.4;
            double redPaint = roof / 4.3;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
