using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            int x1 = Math.Min(first, second);
            int x2 = Math.Max(first, second);
            int distance = 0;

            if (point >= x1 && point <= x2)
            {
                Console.WriteLine("in");
                distance = Math.Min(point - x1, x2 - point);
            }
            else
            {
                Console.WriteLine("out");
                distance = Math.Min(Math.Abs(point - x1), Math.Abs(point - x2));
            }
            Console.WriteLine(distance);            
        }
    }
}
