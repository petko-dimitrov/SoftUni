using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool isOutside = y > 4 * h || y < 0 || (y > h && (x < h || x > 2 * h)) ||
                             x > 3 * h || x < 0;
            bool isInside = y < 4 * h && y > 0 && (y < h || (x > h && x < 2 * h)) &&
                            x < 3 * h && x > 0;
            if (isInside)
            {
                Console.WriteLine("inside");
            }
            else if (isOutside)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
