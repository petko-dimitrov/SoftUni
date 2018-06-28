using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> occurrences = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!occurrences.ContainsKey(number))
                {
                    occurrences[number] = 0;
                }
                occurrences[number]++;
            }

            foreach (var count in occurrences)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
