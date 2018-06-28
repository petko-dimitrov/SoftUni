using System;
using System.Linq;

namespace _09.JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool jumpIsPossible = true;
            int index = 0;
            int sum = numbers[0];

            while (jumpIsPossible)
            {
                if (index + numbers[index] < numbers.Length)
                {
                    index = index + numbers[index];
                    sum += numbers[index];
                }
                else if (index - numbers[index] >= 0)
                {
                    index = index - numbers[index];
                    sum += numbers[index];
                }
                else
                {
                    jumpIsPossible = false;
                }
            }

            Console.WriteLine(sum);
        }
    }
}