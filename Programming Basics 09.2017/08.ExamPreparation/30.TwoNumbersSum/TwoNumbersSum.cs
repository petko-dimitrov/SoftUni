using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            bool combinationFound = false;

            for (int num1 = start; num1 >= end; num1--)
            {
                if (combinationFound)
                {
                    break;
                }
                for (int num2 = start; num2 >= end; num2--)
                {
                    count++;
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",
                            count, num1, num2, magicNum);
                        combinationFound = true;
                        break;
                    }
                }
            }

            if (!combinationFound)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", count, magicNum);
            }
        }
    }
}
