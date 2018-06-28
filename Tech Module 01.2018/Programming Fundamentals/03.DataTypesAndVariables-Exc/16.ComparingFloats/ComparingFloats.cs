using System;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool areEqual = true;

            if (Math.Abs(a - b) > 0.000001)
            {
                areEqual = false;
            }
            Console.WriteLine(areEqual);
        }
    }
}
