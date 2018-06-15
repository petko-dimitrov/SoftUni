using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool isInFirstRectangle = x >= 4 && x <= 10 && y <= 3 && y >= -5;
            bool isInSecondReactangle = x >= 2 && x <= 12 && y <= 1 && y >= -3;

            if (isInFirstRectangle || isInSecondReactangle)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
