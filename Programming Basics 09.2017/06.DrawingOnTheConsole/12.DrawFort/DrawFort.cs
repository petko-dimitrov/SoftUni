using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int downDash = n - 2;

            // First Row
            Console.Write('/');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('^');
                downDash--;
            }
            Console.Write("\\");
            Console.Write(new string('_', 2 * downDash));

            Console.Write('/');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('^');
            }
            Console.WriteLine("\\");

            // Middle part
            for (int row = 2; row <= n - 2; row++)
            {
                for (int col = 1; col <= 2 * n; col++)
                {
                    if (col == 1 || col == 2 * n)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Bottom part
            Console.Write('|');
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(' ');
            }
            Console.Write(new string('_', 2 * downDash));
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine('|');

            // Last row
            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write("/");
            Console.Write(new string(' ', 2 * downDash));

            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine("/");
        }
    }
}
