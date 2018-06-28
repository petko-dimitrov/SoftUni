using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number >= 0)
                {
                    resultNumbers.Add(number);
                }
            }

            resultNumbers.Reverse();
            if (resultNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", resultNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
