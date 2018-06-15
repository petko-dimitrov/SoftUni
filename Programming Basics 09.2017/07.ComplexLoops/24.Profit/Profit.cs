using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int ones = 0; ones <= one; ones++)
            {
                for (int twos = 0; twos <= two; twos++)
                {
                    for (int fives = 0; fives <= five; fives++)
                    {
                        if (fives * 5 + twos * 2 + ones * 1 == sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.",
                                ones, twos, fives, sum);
                        }
                    }
                }
            }
        }
    }
}
