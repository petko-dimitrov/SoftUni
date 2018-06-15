using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing4Numbers
{
    class Increasing4Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 4)
            {
                Console.WriteLine("no");
            }
            for (int n1 = a; n1 <= b - 3; n1++)
            {
                for (int n2 = a + 1; n2 <= b - 2; n2++)
                {
                    for (int n3 = a + 2; n3 <= b - 1; n3++)
                    {
                        for (int n4 = a + 3; n4 <= b; n4++)
                        {
                            if (n1 < n2 && n2 < n3 && n3 < n4)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
                            }
                        }
                    }
                }
            }
        }
    }
}
