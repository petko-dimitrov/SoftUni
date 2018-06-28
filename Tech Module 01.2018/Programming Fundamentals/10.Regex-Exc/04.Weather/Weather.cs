using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04.Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+\.\d{1,2})(?<type>[A-Za-z]+)(?=\|)";
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<double, string>> forecasts =
                new Dictionary<string, Dictionary<double, string>>();
                
            while (input != "end")
            {
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }
                var currentForecast = Regex.Match(input, pattern);
                string city = currentForecast.Groups["city"].Value;
                double temperature = double.Parse(currentForecast.Groups["temp"].Value);
                string weatherType = currentForecast.Groups["type"].Value;

                Dictionary<double, string> currentWeather = new Dictionary<double, string>();
                currentWeather.Add(temperature, weatherType);

                if (!forecasts.ContainsKey(city))
                {
                    forecasts.Add(city, currentWeather);
                }
                else
                {
                    forecasts[city] = currentWeather;
                }

                input = Console.ReadLine();
            }

            foreach (var forecast in forecasts.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var pair in forecast.Value)
                {
                    Console.WriteLine($"{forecast.Key} => {pair.Key:f2} => {pair.Value}");
                }
            }
        }
    }
}
