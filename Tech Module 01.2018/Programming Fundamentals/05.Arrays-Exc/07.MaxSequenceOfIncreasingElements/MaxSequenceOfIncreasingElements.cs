using System;
using System.Linq;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int longestLength = 1;
            int startIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > longestLength)
                    {
                        longestLength = counter;
                        startIndex = i - longestLength;
                    }
                    counter = 1;
                }
                if (i == numbers.Length - 1)
                {
                    if (counter > longestLength)
                    {
                        longestLength = counter;
                        startIndex = i - longestLength + 1;
                    }
                }
            }

            for (int i = startIndex; i < longestLength + startIndex; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
