using System;

namespace _09.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = CalculateLineLength(x1, y1, x2, y2);
            double secondLineLength = CalculateLineLength(x3, y3, x4, y4);
            if (firstLineLength >= secondLineLength)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }

        }

        static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return length;
        }

        static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distance1 <= distance2)
            {
                Console.Write($"({x1}, {y1})");
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
