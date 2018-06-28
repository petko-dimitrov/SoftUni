using System;
using System.Collections.Generic;
using System.Linq;

namespace _18.SoftUniWaterSupply
{
    class SoftUniWaterSupply
    {
        static void Main(string[] args)
        {
            decimal totalWater = decimal.Parse(Console.ReadLine());
            decimal[] bottles = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            long bottleCapacity = long.Parse(Console.ReadLine());
            List<int> notFilledBottles = new List<int>();
            decimal totalWaterNeeded = 0;

            if (totalWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    FillBottles(ref totalWater, bottles, bottleCapacity, notFilledBottles, ref totalWaterNeeded, i);
                }
            }

            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    FillBottles(ref totalWater, bottles, bottleCapacity, notFilledBottles, ref totalWaterNeeded, i);
                }
            }

            if (notFilledBottles.Count == 0)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalWater}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {notFilledBottles.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", notFilledBottles)}");
                Console.WriteLine($"We need {totalWaterNeeded} more liters!");
            }
        }

        static void FillBottles(ref decimal totalWater, decimal[] bottles, long bottleCapacity, List<int> notFilledBottles, ref decimal totalWaterNeeded, int i)
        {
            decimal waterNeeded = bottleCapacity - bottles[i];

            if (totalWater == 0)
            {
                notFilledBottles.Add(i);
                totalWaterNeeded += waterNeeded;
            }
            else if (totalWater < waterNeeded)
            {
                totalWaterNeeded += (waterNeeded - totalWater);
                totalWater = 0;
                notFilledBottles.Add(i);
            }
            else
            {
                totalWater -= waterNeeded;
            }
        }
    }
}
