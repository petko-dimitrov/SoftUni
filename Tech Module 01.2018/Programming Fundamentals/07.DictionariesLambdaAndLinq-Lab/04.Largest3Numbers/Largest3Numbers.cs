using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var largest3Nums = numbers.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}
