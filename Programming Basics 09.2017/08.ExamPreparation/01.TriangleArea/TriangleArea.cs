using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int a = Math.Max(x2, x3) - Math.Min(x2, x3);
            double h = Math.Max(y1, y2) - Math.Min(y1, y2);
            double area = a * h / 2;
            Console.WriteLine(area);
        }
    }
}
