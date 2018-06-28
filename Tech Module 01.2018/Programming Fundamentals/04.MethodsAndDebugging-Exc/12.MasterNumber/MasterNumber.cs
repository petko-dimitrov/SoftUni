using System;

namespace _12.MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int numberToCheck = 1; numberToCheck <= n; numberToCheck++)
            {
                bool isPalidrome = CheckIfIsPalidrome(numberToCheck);
                bool sumOfDigitsIsDivisibleBy7 = CheckIfSumOfDigitsIsDivisibleBy7(numberToCheck);
                bool containsEvenDigit = CheckIfContainsEvenDigit(numberToCheck);
                if (isPalidrome && sumOfDigitsIsDivisibleBy7 && containsEvenDigit)
                {
                    Console.WriteLine(numberToCheck);
                }
            }
        }

        private static bool CheckIfContainsEvenDigit(int numberToCheck)
        { 
            bool hasEvenDigit = false;
            while (numberToCheck > 0)
            {
                int currentDigit = numberToCheck % 10;
                if (currentDigit % 2 == 0)
                {
                    hasEvenDigit = true;
                    return hasEvenDigit;
                }
                numberToCheck /= 10;
            }
            return hasEvenDigit;
        }

        private static bool CheckIfSumOfDigitsIsDivisibleBy7(int numberToCheck)
        {
            bool isSumOfDigitsDivisibleBy7 = false;
            int sumOfDigits = 0;
            while (numberToCheck > 0)
            {
                int currentDigit = numberToCheck % 10;
                sumOfDigits += currentDigit;
                numberToCheck /= 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                isSumOfDigitsDivisibleBy7 = true;
            }
            return isSumOfDigitsDivisibleBy7;
        }

        private static bool CheckIfIsPalidrome(int numberToCheck)
        {
            bool isPalindrome = false;
            int reverseNumber = 0;
            int power = 0;
            int savedNumberToCheck = numberToCheck;

            while (numberToCheck > 0)
            {
                int currentNumber = numberToCheck % 10;
                numberToCheck /= 10;
                int tempNumber = numberToCheck;
                while (tempNumber > 0)
                {
                    tempNumber /= 10;
                    power++;
                }
                reverseNumber += currentNumber * (int)Math.Pow(10, power);
                power = 0;
            }

            if (reverseNumber == savedNumberToCheck)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
