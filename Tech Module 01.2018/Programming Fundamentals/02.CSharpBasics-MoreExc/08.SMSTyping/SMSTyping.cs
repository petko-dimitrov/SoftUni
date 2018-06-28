using System;

namespace _08.SMSTyping
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfDigits = 0;
            int mainDigit = 0;
            int offset = 0;
            int letterIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 10)
                {
                    numberOfDigits = 1;
                }
                else if (number < 100)
                {
                    numberOfDigits = 2;
                }
                else if (number < 1000)
                {
                    numberOfDigits = 3;
                }
                else
                {
                    numberOfDigits = 4;
                }
                mainDigit = number % 10;
                offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                letterIndex = offset + numberOfDigits - 1;
                if (number == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write($"{(char)(letterIndex + 97)}");
                }
            }

        }
    }
}
