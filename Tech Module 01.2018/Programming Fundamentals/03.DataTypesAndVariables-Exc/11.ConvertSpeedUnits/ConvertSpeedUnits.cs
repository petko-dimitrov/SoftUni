using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
           
            float totalSeconds = seconds + minutes * 60 + hours * 3600;
            float totalHours = totalSeconds / 3600;

            float metersPerSecond = distanceInMeters / totalSeconds;
            float kilometersPerHour = distanceInMeters / 1000.0f / totalHours;
            float milesPerHour = kilometersPerHour / 1.609f;

            Console.WriteLine($"{metersPerSecond:0.######}");
            Console.WriteLine($"{kilometersPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");

        }
    }
}
