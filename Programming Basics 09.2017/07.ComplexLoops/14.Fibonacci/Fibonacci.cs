using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;

            for (int i = 0; i < n-1; i++)
            {
                int fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }
            Console.WriteLine(f2);
        }
    }
}
