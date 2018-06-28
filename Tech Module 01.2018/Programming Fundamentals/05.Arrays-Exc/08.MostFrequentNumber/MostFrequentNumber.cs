 using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int maxCount = 0;
            int maxNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            { 
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxNum = numbers[i];
                }
                counter = 1;
            }

            Console.WriteLine(maxNum);
        }
    }
}
