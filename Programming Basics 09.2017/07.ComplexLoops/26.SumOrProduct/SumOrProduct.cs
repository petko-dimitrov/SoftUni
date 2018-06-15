using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.SumOrProduct
{
    class SumOrProduct
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool noCombinations = true;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n && a < b && b < c)
                        {
                            noCombinations = false;
                            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, n);
                        }
                        if (a * b * c == n && a > b && b > c)
                        {
                            noCombinations = false;
                            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, n);
                        }
                    }
                }
            }

            if (noCombinations)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
