using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bestStart = 0;
            int bestLength = 0;
            int start = 0;
            int length = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    length++;
                    if (i == numbers.Count - 2 && length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else if(length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                    length = 1;
                    start = i + 1;
                }
                else
                {
                    length = 1;
                    start = i + 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
