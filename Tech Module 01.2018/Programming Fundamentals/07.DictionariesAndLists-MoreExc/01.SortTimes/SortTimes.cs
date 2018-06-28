using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split(' ').ToList();
            times = times.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", times));
        }
    }
}
