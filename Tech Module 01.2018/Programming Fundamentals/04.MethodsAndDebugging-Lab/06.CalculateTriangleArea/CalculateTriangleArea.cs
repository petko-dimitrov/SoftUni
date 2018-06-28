using System;

namespace _06.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = CalculateAreaOfTriangle(a, h);
            Console.WriteLine(area);
        }

        static double CalculateAreaOfTriangle(double a, double h)
        {
            double area = a * h / 2;
            return area;
        }
    }
}
