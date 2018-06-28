using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] groupsOfNumbers = Console.ReadLine().Split('|').ToArray();
            List<int> numbers = new List<int>();

            for (int i = groupsOfNumbers.Length - 1; i >= 0; i--)
            {
                numbers.AddRange(groupsOfNumbers[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
