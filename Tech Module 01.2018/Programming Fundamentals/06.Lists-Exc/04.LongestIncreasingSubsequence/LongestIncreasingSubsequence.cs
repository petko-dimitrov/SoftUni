using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] length = new int[numbers.Count];
            int lastIndex = -1;
            int maxLength = 0;
            int[] previous = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                length[i] = 1;
                previous[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] > numbers[j] && length[j] + 1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        previous[i] = j;
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }

            }

            List<int> largestIncrSeq = new List<int>();

            while (lastIndex != -1)
            {
                largestIncrSeq.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            largestIncrSeq.Reverse();
            Console.WriteLine(string.Join(" ", largestIncrSeq));
        }
    }
}
