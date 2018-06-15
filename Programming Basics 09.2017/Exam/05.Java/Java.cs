using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Java
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 6;
            int height = 3 * n + 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
            }

            Console.WriteLine(new string('=', width - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', width - 2 * n - 7));
                }
                else
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', 2 * n + 4), new string(' ', width - 2 * n - 7));
                }
            }

            Console.WriteLine(new string('=', width - 1));

            int spaces = 0;
            int dots = 2 * n + 4;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/", new string(' ', spaces), new string('@', dots));
                spaces++;
                dots -= 2;
            }

            Console.WriteLine(new string('=', 2 * n + 6));
        }
    }
}
