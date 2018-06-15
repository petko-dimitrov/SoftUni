using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int d3 = n % 10;
            n = n / 10;
            int d2 = n % 10;
            int d1 = n / 10;

            for (int row = 1; row <= d1 + d2; row++)
            {
                for (int col = 1; col <= d1 + d3; col++)
                {
                    if (num % 5 == 0)
                    {
                        num -= d1;
                        Console.Write(num + " ");
                    }
                    else if (num % 3 == 0)
                    {
                        num -= d2;
                        Console.Write(num + " ");
                    }
                    else
                    {
                        num += d3;
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
