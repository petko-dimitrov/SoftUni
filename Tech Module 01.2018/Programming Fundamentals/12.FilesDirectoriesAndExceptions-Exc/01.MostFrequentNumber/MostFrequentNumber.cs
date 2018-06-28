using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            string[] outputNumbers = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int[] numbers = input[i].Split().Select(int.Parse).ToArray();
                Dictionary<int, int> numbersCount = new Dictionary<int, int>();
                
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (!numbersCount.ContainsKey(numbers[i]))
                    {
                        numbersCount.Add(numbers[i], 1);
                    }
                    else
                    {
                        numbersCount[numbers[i]]++;
                    }
                }

                int mostFrequentNumber = numbersCount.OrderByDescending(x => x.Value).First().Key;
                outputNumbers[i] = mostFrequentNumber.ToString();
            }

            File.WriteAllLines("output.txt", outputNumbers);
        }
    }
}
