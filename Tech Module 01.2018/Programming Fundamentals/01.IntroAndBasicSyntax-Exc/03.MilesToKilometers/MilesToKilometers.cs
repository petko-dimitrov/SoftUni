using System;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometeres = miles * 1.60934;

            Console.WriteLine($"{kilometeres:f2}");
        }
    }
}
