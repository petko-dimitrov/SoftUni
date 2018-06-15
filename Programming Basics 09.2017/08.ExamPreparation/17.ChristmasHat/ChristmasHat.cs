using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int points = 2 * n - 1;
            int dashes = 0;

            Console.WriteLine("{0}/|\\{0}", new string('.', points));
            Console.WriteLine("{0}\\|/{0}", new string('.', points));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', points), new string('-', dashes));
                points--;
                dashes++;
            }
            Console.WriteLine("{0}", new string('*', width));
            for (int i = 1; i <= width / 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', width));

        }
    }
}
