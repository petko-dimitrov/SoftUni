using System;

namespace _05.WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            string forecast = "";
            try
            {
                long number = long.Parse(Console.ReadLine());
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    forecast = "Sunny";
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    forecast = "Cloudy";
                }
                else
                {
                    forecast = "Windy";
                }
            }
            catch (Exception)
            {
                forecast = "Rainy";
            }

            Console.WriteLine(forecast);
        }
    }
}
