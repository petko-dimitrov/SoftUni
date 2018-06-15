using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IncreasingElements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int maxCount = 0;
            int num1 = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > num1)
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                    count = 1;
                }
                num1 = num;
            }
            Console.WriteLine(Math.Max(count, maxCount));
        }
    }
}
