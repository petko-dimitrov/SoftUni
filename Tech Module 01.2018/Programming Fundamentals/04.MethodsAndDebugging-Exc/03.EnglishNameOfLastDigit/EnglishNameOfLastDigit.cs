using System;

namespace _03.EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsWord(number));
        }

        static string GetLastDigitAsWord(long number)
        {
            number = Math.Abs(number);
            long lastDigit = number % 10;
            string lastDigitAsWord = "";

            switch (lastDigit)
            {
                case 0:
                    lastDigitAsWord = "zero";
                    break;
                case 1:
                    lastDigitAsWord = "one";
                    break;
                case 2:
                    lastDigitAsWord = "two";
                    break;
                case 3:
                    lastDigitAsWord = "three";
                    break;
                case 4:
                    lastDigitAsWord = "four";
                    break;
                case 5:
                    lastDigitAsWord = "five";
                    break;
                case 6:
                    lastDigitAsWord = "six";
                    break;
                case 7:
                    lastDigitAsWord = "seven";
                    break;
                case 8:
                    lastDigitAsWord = "eight";
                    break;
                case 9:
                    lastDigitAsWord = "nine";
                    break;
                default:
                    break;
            }

            return lastDigitAsWord;
        }
    }
}
