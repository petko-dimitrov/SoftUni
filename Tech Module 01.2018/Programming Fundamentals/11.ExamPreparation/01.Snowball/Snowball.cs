using System;
using System.Numerics;

namespace _01.Snowball
{
    class Snowball
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int maxSnow = int.MinValue;
            int maxTime = int.MinValue;
            int maxQuality = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow / time, quality);
                if (value > maxValue)
                {
                    maxValue = value;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
