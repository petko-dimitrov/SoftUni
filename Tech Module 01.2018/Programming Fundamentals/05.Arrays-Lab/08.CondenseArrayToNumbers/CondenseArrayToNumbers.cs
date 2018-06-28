using System;
using System.Linq;

namespace _08.CondenseArrayToNumbers
{
    class CondenseArrayToNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            int[] condensed = new int[numbers.Length - 1];
            int condensedLength = condensed.Length;

            while (condensedLength >= 1)
            {
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                for (int i = 0; i < condensed.Length; i++)
                {
                    numbers[i] = condensed[i];
                }
                condensedLength--;
            }

            Console.WriteLine(condensed[0]);
        }
    }
}
