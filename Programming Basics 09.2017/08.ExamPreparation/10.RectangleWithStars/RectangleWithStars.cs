using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;

            Console.WriteLine(new string('%', width));

            if (n % 2 == 0)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    if (i == n / 2)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', (width-4) / 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', width - 2));
                    }
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n / 2 + 1)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', (width - 4) / 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', width - 2));
                    }
                }
            }

            Console.WriteLine(new string('%', width));
        }
    }
}
