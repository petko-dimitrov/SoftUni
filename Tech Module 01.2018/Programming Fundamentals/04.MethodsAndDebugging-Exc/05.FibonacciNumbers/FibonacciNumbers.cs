using System;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFibonacci(number));
        }

        static int CalculateFibonacci(int number)
        {
            int fibonacciNumber = 1;
            int currentFibonacci = 1;
            int previousFibonacci = 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacciNumber = currentFibonacci + previousFibonacci;
                previousFibonacci = currentFibonacci;
                currentFibonacci = fibonacciNumber;
            }

            return fibonacciNumber;
        }
    }
}
