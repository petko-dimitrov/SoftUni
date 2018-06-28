using System;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfANumberIsPrime(number));
        }

        static bool CheckIfANumberIsPrime(long number)
        {
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
                return isPrime;
            }

            for (long divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}

