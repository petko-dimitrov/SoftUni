using System;

namespace _03.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalWater = 0;

            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());
                if (totalWater + litersToPour > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalWater += litersToPour;
                }
            }

            Console.WriteLine(totalWater);
        }
    }
}
