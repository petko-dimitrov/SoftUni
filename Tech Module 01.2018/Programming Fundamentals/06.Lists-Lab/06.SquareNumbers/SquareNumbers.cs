using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (Math.Sqrt(1.0* number) == (int)Math.Sqrt(1.0 * number))
                {
                    squareNumbers.Add(number);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
