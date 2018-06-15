using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int height = 2 * n + 1;
            int dots = 1;
            int sharps = 2 * n - 1;
            int spaces = 1;

            Console.WriteLine(new string('#', width));
            for (int i = 1; i <= n; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', dots), new string('#', sharps),
                        new string(' ', (spaces - 3) / 2));

                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dots),
                        new string('#', sharps), new string(' ', spaces));
                }
                dots++;
                sharps -= 2;
                spaces += 2;
            }

            sharps = spaces - 2;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', sharps));
                dots++;
                sharps -= 2;
            }
        }
    }
}
