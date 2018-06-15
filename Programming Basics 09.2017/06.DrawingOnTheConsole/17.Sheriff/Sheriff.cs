using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Sheriff
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = 2 * n + 8;
            int cols = 3 * n;

            Console.WriteLine("{0}x{0}", new string ('.', cols/2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (cols - 3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (cols - 3) / 2));

            int x = n;
            int dots = cols / 2 - x;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', x));
                if (i <= n / 2)
                {
                    x++;
                    dots--;
                }
                else
                {
                    x--;
                    dots++;
                }
            }

            Console.WriteLine("{0}/x\\{0}", new string('.', (cols - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (cols - 3) / 2));

            x = n;
            dots = cols / 2 - x;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', dots), new string('x', x));
                if (i <= n / 2)
                {
                    x++;
                    dots--;
                }
                else
                {
                    x--;
                    dots++;
                }
            }

            Console.WriteLine("{0}x|x{0}", new string('.', (cols - 3)/2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (cols - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', cols / 2));
        }
    }
}
