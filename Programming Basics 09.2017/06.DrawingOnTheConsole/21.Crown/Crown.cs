using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Crown
{
    class Crown
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = n / 2 + 4;
            int spaces = (width - 3) / 2;
            int dots = 1;
            int middleDots = 1;

            Console.WriteLine("@{0}@{0}@", new string(' ', spaces));
            spaces--;
            Console.WriteLine("**{0}*{0}**", new string(' ', spaces));
            spaces -= 2;

            while (spaces >= 0)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', dots), new string(' ', spaces),
                    new string('.', middleDots));
                dots++;
                middleDots += 2;
                spaces -= 2;
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dots), new string('.', middleDots));
            dots++;
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', dots), new string('*', middleDots / 2));
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('*', width));
        }
    }
}
