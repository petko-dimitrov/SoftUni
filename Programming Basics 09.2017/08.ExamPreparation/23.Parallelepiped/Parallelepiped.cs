using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            int height = 4 * n + 4;
            int leftDots = 0;
            int rightDots = width - n;
            
            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', rightDots));
            rightDots--;

            for (int i = 1; i <= 2 * n + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                    new string('.', leftDots), new string('~', n - 2), new string('.', rightDots));
                leftDots++;
                rightDots--;
            }

            leftDots--;
            rightDots++;
            for (int i = 1; i <= 2 * n + 1; i++)
            {
                Console.WriteLine("{2}\\{0}|{1}|",
                    new string('.', leftDots), new string('~', n - 2), new string('.', rightDots));
                leftDots--;
                rightDots++;
            }

            Console.WriteLine("{0}+{1}+", new string('.', rightDots), new string('~', n - 2));
        }
    }
}
