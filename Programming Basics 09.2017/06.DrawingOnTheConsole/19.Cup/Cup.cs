using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Cup
{
    class Cup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int firstDiezPos = n + 1;
            int lastDiezPos = width - n;

            for (int rows = 1; rows <= n / 2; rows++)
            {
                for (int cols = 1; cols <= width; cols++)
                {
                    if (cols >= firstDiezPos && cols <= lastDiezPos)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                firstDiezPos++;
                lastDiezPos--;
                Console.WriteLine();
            }

            for (int rows = 1; rows <= n / 2 + 1; rows++)
            {
                for (int cols = 1; cols <= width; cols++)
                {
                    if (cols == firstDiezPos || cols == lastDiezPos)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                firstDiezPos++;
                lastDiezPos--;
                Console.WriteLine();
            }

            Console.WriteLine("{0}{1}{0}", new string('.', 2*n), new string('#', n));

            int dancePos = (width - 10) / 2;
            int dotsPos = (width - n - 4) / 2;
            for (int rows = 1; rows <= n + 2; rows++)
            {
                if (rows == (n+2)/2)
                {
                    Console.Write("{0}D^A^N^C^E^{0}", new string('.', dancePos));
                }
                else
                {
                    Console.Write("{0}{1}{0}", new string('.', dotsPos), new string('#', n+4));
                }
                Console.WriteLine();
            }
        }
    }
}
