using System;
using System.Linq;

namespace _03.IntersectionOfCircles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle();
            Circle circle2 = ReadCircle();

            bool intersect = circle1.Intersect(circle2);
            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Circle ReadCircle()
        {
            double[] circleInfo = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle circle = new Circle();
            Point point = new Point();
            point.X = circleInfo[0];
            point.Y = circleInfo[1];
            circle.Center = point;
            circle.Radius = circleInfo[2];
            return circle;
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool Intersect(Circle circle)
        {
            bool intersect = false;
            double distance = Math.Sqrt(Math.Pow(Center.X - circle.Center.X, 2)
                                                + Math.Pow(Center.Y - circle.Center.Y, 2));
            if (distance <= Radius + circle.Radius)
            {
                intersect = true;
            }
            return intersect;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }
}
