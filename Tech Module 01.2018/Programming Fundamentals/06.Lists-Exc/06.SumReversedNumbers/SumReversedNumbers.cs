using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                string currentNum = numbers[i].ToString();
                string reversed = "";
                for (int j = currentNum.Length - 1; j >= 0; j--)
                {
                    reversed += currentNum[j];
                }
                numbers[i] = int.Parse(reversed);
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
