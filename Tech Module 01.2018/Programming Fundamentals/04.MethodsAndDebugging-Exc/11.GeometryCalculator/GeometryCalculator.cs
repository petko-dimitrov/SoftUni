using System;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine().ToLower();
            double area = 0;

            switch (typeOfFigure)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = CalculateTriangleArea(triangleSide, triangleHeight);
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    area = CalculateSquareArea(squareSide);
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    area = CalculateRectangleArea(rectangleWidth, rectangleHeight);
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    area = CalculateCircleArea(circleRadius);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{area:f2}");
        }

        private static double CalculateCircleArea(double circleRadius)
        {
            double area = Math.PI * circleRadius * circleRadius;
            return area;
        }

        private static double CalculateRectangleArea(double rectangleWidth, double rectangleHeight)
        {
            double area = rectangleWidth * rectangleHeight;
            return area;
        }

        private static double CalculateSquareArea(double squareSide)
        {
            double area = Math.Pow(squareSide, 2);
            return area;
        }

        private static double CalculateTriangleArea(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
    }
}
