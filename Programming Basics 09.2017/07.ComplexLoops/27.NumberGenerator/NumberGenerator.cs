using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.NumberGenerator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            bool controlIsReached = false;

            for (int d1 = m; d1 >= 1; d1--)
            {

                if (special >= control)
                {
                    controlIsReached = true;
                    break;
                }
                for (int d2 = n; d2 >= 1; d2--)
                {
                    if (special >= control)
                    {
                        controlIsReached = true;
                        break;
                    }
                    for (int d3 = l; d3 >=1; d3--)
                    {
                        int num = d1 * 100 + d2 * 10 + d3;
                        if (num % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (num % 10 == 5)
                        {
                            special -= 2;
                        }
                        else if (num % 2 == 0)
                        {
                            special *= 2;
                        }
                        if (special >= control)
                        {
                            controlIsReached = true;
                            break;
                        }
                    }
                }
            }

            if (!controlIsReached)
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }
            else
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
            }
        }
    }
}
