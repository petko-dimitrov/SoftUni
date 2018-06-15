using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string star = "*";
            string space = " ";
            for (int i = 1; i < n; i++)
            {
                star += "*";
            }
            Console.WriteLine(star);
            for (int j = 0; j < n-3; j++)
            {
                space += " ";
            }
            for (int k = 0; k < n-2; k++)
            {
                Console.Write("*");
                Console.Write(space);
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(star);
        }
    }
}