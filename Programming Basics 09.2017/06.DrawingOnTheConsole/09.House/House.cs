using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double roofRows = Math.Ceiling(n / 2.0);

            for (int row = 1; row <= roofRows; row++)
            {
                Console.Write(new string('-', (int)roofRows - row));
                if (n % 2 == 0)
                {
                    Console.Write(new string('*', 2 * row));
                }
                else
                {
                    Console.Write(new string('*', 2 * row - 1));
                }
                Console.Write(new string('-', (int)roofRows - row));
                Console.WriteLine();
            }

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
