using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ThreeNumbersSum
{
    class ThreeNumbersSum
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int a = Math.Min(first, second);
            a = Math.Min(a, third);
            int c = Math.Max(first, second);
            c = Math.Max(c, third);
            int b = c - a;

            if (first + second == third || first + third == second || second + third == first)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
