using System;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primeNumbers = new bool[n + 1];

            for (int i = 0; i < primeNumbers.Length; i++)
            {
                primeNumbers[i] = true;
            }
            primeNumbers[0] = false;
            primeNumbers[1] = false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (primeNumbers[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primeNumbers[j] = false;
                    }
                }
            }

            for (int i = 0; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
