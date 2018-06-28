using System;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = CalculateFactorial(number);
            int trailingZeros = CountTrailingZerosOfFactorial(factorial);
            Console.WriteLine(trailingZeros);
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int CountTrailingZerosOfFactorial(BigInteger factorial)
        {
            BigInteger currentDigit = 0;
            int count = 0;

            while (currentDigit == 0)
            {
                currentDigit = factorial % 10;
                if (currentDigit == 0)
                {
                    count++;
                }
                factorial /= 10;
            }

            return count;
        } 
    }
}
