using System;

namespace _09.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyEvenByOddDigits(number));
        }

        static int MultiplyEvenByOddDigits(int number)
        {
            int evenDigitsSum = 0;
            int oddDigitsSum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0)
                {
                    evenDigitsSum += currentDigit;
                }
                else
                {
                    oddDigitsSum += currentDigit;
                }
                number /= 10;
            }
            int result = evenDigitsSum * oddDigitsSum;
            return result;
        }
    }
}
