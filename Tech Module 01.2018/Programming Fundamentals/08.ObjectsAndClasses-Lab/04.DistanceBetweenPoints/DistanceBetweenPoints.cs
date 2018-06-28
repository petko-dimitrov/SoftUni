using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point1 = new Point() { X = first[0], Y = first[1] };
            Point point2 = new Point() { X = second[0], Y = second[1] };
            double distance = CalculateDistance(point1, point2);
            Console.WriteLine("{0:f3}", distance);
        }

        static double CalculateDistance(Point point1, Point point2)
        {
            double a = point1.X - point2.X;
            double b = point1.Y - point2.Y;
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

