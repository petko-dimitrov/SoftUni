using System;
using System.Collections.Generic;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            List<int> primesInRange = FindPrimesInRange(firstNumber, secondNumber);
            PrintPrimesInRange(primesInRange);
        }

        static List<int> FindPrimesInRange(int firstNumber, int secondNumber)
        {
            List<int> primeNumbers = new List<int>();

            for (int numberToCheck = firstNumber; numberToCheck <= secondNumber; numberToCheck++)
            {
                bool isPrime = true;
                if (numberToCheck == 0 || numberToCheck == 1)
                {
                    isPrime = false;
                    continue;
                }
                for (int divisor = 2; divisor <= Math.Sqrt(numberToCheck); divisor++)
                {
                    if (numberToCheck % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(numberToCheck);
                }
            }

            return primeNumbers;
        }

        static void PrintPrimesInRange(List<int> primeNumbers)
        {
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (i != primeNumbers.Count - 1)
                {
                    Console.Write($"{primeNumbers[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{primeNumbers[i]}");
                }
            }
        }
    }
}
