using System;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = ReadPont();
            }

            Point[] closestTwoPoints = FindClosestTwoPoints(points);
            Console.WriteLine("{0:f3}", CalculateDistance(closestTwoPoints[0], closestTwoPoints[1]));
            Console.WriteLine("({0}, {1})", closestTwoPoints[0].X, closestTwoPoints[0].Y);
            Console.WriteLine("({0}, {1})", closestTwoPoints[1].X, closestTwoPoints[1].Y);
        }

        static double CalculateDistance(Point point1, Point point2)
        {
            double a = point1.X - point2.X;
            double b = point1.Y - point2.Y;
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = new Point[2];

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints[0] = points[i];
                        closestTwoPoints[1] = points[j];
                    }
                }
            }

            return closestTwoPoints;
        }

        static Point ReadPont()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point() { X = pointInfo[0], Y = pointInfo[1] };
            return point;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
