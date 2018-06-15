using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Firs row
            Console.WriteLine("{0}{1}{0}", new string('.', n/2), new string('#', n));
            //Body
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', n/2), new string('.', n - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
            //Head
            int firstDiezPosition = 2;
            int secondDiezPosition = 2 * n - 2;

            for (int row = 1; row <= n - 1; row++)
            {
                for (int col = 1; col <= 2 * n - 1; col++)
                {
                    if (col == firstDiezPosition || col == secondDiezPosition)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                firstDiezPosition++;
                secondDiezPosition--;
                Console.WriteLine();
            }
        }
    }
}
