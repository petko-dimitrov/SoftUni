using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = 2 * n + 1;
            int cols = 2 * n + 3;
            int firstStarPosition = 1;
            int middleStarPosition = n + 2;
            int lastStarPosition = cols;

            for (int i = 1; i <= n-1; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (j == firstStarPosition || j == middleStarPosition || j == lastStarPosition)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                firstStarPosition++;
                lastStarPosition--;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            Console.WriteLine(new string('*', cols));
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            firstStarPosition--;
            lastStarPosition++;

            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (j == firstStarPosition || j == middleStarPosition || j == lastStarPosition)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                firstStarPosition--;
                lastStarPosition++;
            }
        }
    }
}
