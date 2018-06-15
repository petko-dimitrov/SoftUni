using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.TheSongOfTheWheels
{
    class TheSongOfTheWheels
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            string password = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a*b + c*d == m && a < b && c > d)
                            {
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                                count++;
                            }
                            if (count == 3)
                            {
                                password = $"{a}{b}{c}{d+1}";
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            if (count < 4)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine("Password: {0}", password);
            }
        }
    }
}
