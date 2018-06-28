using System;
using System.Linq;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            bool sequenceFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j > i && numbers.Contains(numbers[i] + numbers[j]))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[i] + numbers[j]}");
                        sequenceFound = true;
                    }
                }
            }

            if (!sequenceFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
