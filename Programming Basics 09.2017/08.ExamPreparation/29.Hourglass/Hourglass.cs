using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int dots = 2;
            int monkeys = width - 6;

            Console.WriteLine(new string('*', width));
            Console.WriteLine(".*{0}*.", new string(' ', width - 4));

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string ('.', dots), new string('@', monkeys));
                dots++;
                monkeys -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('.', dots));
            dots--;
            int spaces = 0;

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', dots), new string(' ', spaces));
                dots--;
                spaces++;
            }

            Console.WriteLine(".*{0}*.", new string ('@', width - 4));
            Console.WriteLine(new string('*', width));
        }
    }
}
