using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cols = n * 2 - 1;
            int spaces = n - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write("{0}", new string(' ', spaces));
                for (int i = 1; i < row; i++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*{0}", new string(' ', spaces));
                spaces--;
            }
            spaces += 2;
            for (int row = n -1; row >= 1; row--)
            {
                Console.Write("{0}", new string(' ', spaces));
                for (int i = 1; i < row; i++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*{0}", new string(' ', spaces));
                spaces++;
            }
            
        }
    }
}
