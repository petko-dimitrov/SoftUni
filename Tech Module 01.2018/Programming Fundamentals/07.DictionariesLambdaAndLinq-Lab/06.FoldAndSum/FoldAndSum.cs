using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();

            row1 = numbers.Take(k).Reverse().ToList();
            row1.AddRange(numbers.Reverse().Take(k));
            row2 = numbers.Skip(k).Take(2 * k).ToList();
            
            List<int> sum = row1.Select((x, index) => x + row2[index]).ToList();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
