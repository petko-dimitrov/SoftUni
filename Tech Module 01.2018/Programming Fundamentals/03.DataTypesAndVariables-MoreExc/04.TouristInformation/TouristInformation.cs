using System;

namespace _04.TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnitType = Console.ReadLine().ToLower();
            double value = double.Parse(Console.ReadLine());
            double result = 0;
            string metricUnitType = "";

            switch (imperialUnitType)
            {
                case "miles":
                    result = value * 1.6;
                    metricUnitType = "kilometers";
                    break;
                case "inches":
                    result = value * 2.54;
                    metricUnitType = "centimeters";
                    break;
                case "feet":
                    result = value * 30;
                    metricUnitType = "centimeters";
                    break;
                case "yards":
                    result = value * 0.91;
                    metricUnitType = "meters";
                    break;
                case "gallons":
                    result = value * 3.8;
                    metricUnitType = "liters";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{value} {imperialUnitType} = {result:f2} {metricUnitType}");
        }
    }
}
