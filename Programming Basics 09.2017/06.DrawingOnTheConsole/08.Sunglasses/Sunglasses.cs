using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string stars = new string('*', 2 * n);
            string spaces = new string(' ', n);
            string inclinedLines = new string('/', 2 * n - 2);
            string straightLines = new string('|', n);
            double middleRow = Math.Ceiling(n / 2.0);

            Console.Write(stars);
            Console.Write(spaces);
            Console.WriteLine(stars);
            for (int row = 2; row <= n - 1; row++)
            {
                if (row != middleRow)
                {
                    Console.Write('*');
                    Console.Write(inclinedLines);
                    Console.Write('*');
                    Console.Write(spaces);
                    Console.Write('*');
                    Console.Write(inclinedLines);
                    Console.Write('*');
                }
                else
                {
                    Console.Write('*');
                    Console.Write(inclinedLines);
                    Console.Write('*');
                    Console.Write(straightLines);
                    Console.Write('*');
                    Console.Write(inclinedLines);
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.Write(stars);
            Console.Write(spaces);
            Console.WriteLine(stars);
        }
    }
}
