using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            bool areEqual = true;
            int difference = 0;

            for (int i = 0; i < 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum1 += num; 
            }

            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int num = int.Parse(Console.ReadLine());
                    sum2 += num;          
                }
                if (Math.Abs(sum2 - sum1) > difference)
                {
                    difference = Math.Abs(sum2 - sum1);
                }
                sum1 = sum2;
                sum2 = 0;
            }
            if (difference == 0)
            {
                Console.WriteLine("Yes, value={0}", sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", difference);
            }
        }
    }
}
