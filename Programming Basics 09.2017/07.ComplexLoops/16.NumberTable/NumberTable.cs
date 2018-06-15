using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int count = 1;

            for (int i = 1; i <= n; i++)
            {
                num = i;
                count = 1;
                while (num < n)
                {
                    Console.Write(num + " ");
                    num++;
                    count++;
                }
                while (count <= n)
                {
                    Console.Write(num + " ");
                    num--;
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
