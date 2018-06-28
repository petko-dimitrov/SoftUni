using System;

namespace _05.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double degreesInFahrenheit = double.Parse(Console.ReadLine());
            double degreesInCelsius = ConvertFahrenheitToCelsius(degreesInFahrenheit);
            Console.WriteLine($"{degreesInCelsius:f2}");
        }

        static double ConvertFahrenheitToCelsius(double degrees)
        {
            double degreesInCelsius = (degrees - 32) * 5 / 9;
            return degreesInCelsius;
        }
    }
}
