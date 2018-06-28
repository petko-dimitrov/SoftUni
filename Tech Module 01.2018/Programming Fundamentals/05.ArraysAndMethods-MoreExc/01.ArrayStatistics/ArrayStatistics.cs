using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int sum = 0;
            double average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                sum += numbers[i];
            }

            average = 1.0 * sum / numbers.Length;
            Console.WriteLine($"Min = {minNumber}\r\nMax = {maxNumber}\r\nSum = {sum}\r\nAverage = {average}");
        }
    }
}
