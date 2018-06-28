using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int indexOfNumber = -1;
            long sum = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == number)
                {
                    indexOfNumber = i;
                    break;
                }
            }

            for (int i = 0; i < indexOfNumber; i++)
            {
                sum += numbers[i];
            }

            if (indexOfNumber >= 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
