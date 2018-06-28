using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool containsNumber = numbers.Take(command[0]).Skip(command[1]).Contains(command[2]);

            if (containsNumber)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
