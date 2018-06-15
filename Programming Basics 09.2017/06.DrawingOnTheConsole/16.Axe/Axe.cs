using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int firstStarPos = 3 * n + 1;
            int secondStarPos = firstStarPos + 1;
            //upper
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= width; col++)
                {
                    if (col == firstStarPos || col == secondStarPos)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                secondStarPos++;
            }
            secondStarPos--;
            // middle
            for (int row = 1; row <= n / 2; row++)
            {
                for (int col = 1; col <= width; col++)
                {
                    if (col <= 3 * n + 1 || col == secondStarPos)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
            // bottom
            for (int row = 1; row <= n / 2 - 1; row++)
            {
                for (int col = 1; col <= width; col++)
                {
                    if (col == firstStarPos || col == secondStarPos)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                firstStarPos--;
                secondStarPos++;
                Console.WriteLine();
            }
            for (int i = 1; i <= width; i++)
            {
                if (i >= firstStarPos && i <= secondStarPos)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');
                }
            }
        }
    }
}
