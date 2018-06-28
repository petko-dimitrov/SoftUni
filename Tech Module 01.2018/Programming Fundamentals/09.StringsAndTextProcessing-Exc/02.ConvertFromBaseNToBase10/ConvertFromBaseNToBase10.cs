using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _02.ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] baseAndNum = Console.ReadLine().Split();
            string n = baseAndNum[0];
            string number = baseAndNum[1];
            BigInteger numberInBase10 = 0;
            BigInteger numSystem = BigInteger.Parse(n);
           
            for (int i = 0; i < number.Length; i++)
            {
                BigInteger temp = BigInteger.Parse(number[i].ToString())
                                  * BigInteger.Pow(numSystem, number.Length -1 - i);
                numberInBase10 += temp;
            }

            Console.WriteLine(numberInBase10);
        }
    }
}
