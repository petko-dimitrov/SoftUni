using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            BigInteger[] baseAndNum = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger n = baseAndNum[0];
            BigInteger number = baseAndNum[1];
            StringBuilder builder = new StringBuilder();

            while (number > 0)
            {
                builder.Append(number % n);
                number /= n;
            }

            StringBuilder reversed = new StringBuilder();
            for (int i = builder.Length - 1; i >= 0; i--)
            {
                reversed.Append(builder[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
