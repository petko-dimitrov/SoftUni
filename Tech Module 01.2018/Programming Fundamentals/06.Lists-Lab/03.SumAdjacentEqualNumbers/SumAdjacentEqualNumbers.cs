using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToList();
            bool allCombinationsFound = false;

            while (!allCombinationsFound)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == numbers.Count - 1)
                    {
                        allCombinationsFound = true;
                        break;
                    }
                    if (numbers[i] == numbers[i + 1] )
                    {
                        double sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
