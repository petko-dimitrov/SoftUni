using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> modifiedNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    modifiedNumbers.Add(number);
                }
            }

            List<int> oddnumbers = new List<int>();

            foreach (var number in modifiedNumbers)
            {
                if (number > modifiedNumbers.Average())
                {
                   oddnumbers.Add(number + 1);
                }
                else 
                {
                    oddnumbers.Add(number - 1);
                }
            }
            Console.WriteLine(string.Join(" ", oddnumbers));
        }
    }
}
