using System;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(ReverseANumber(number));
        }

        static string ReverseANumber(double number)
        { 
            string numberAsString = number.ToString();
            char[] numberAsCharArray = numberAsString.ToCharArray();
            string reversedNumber = "";
            for (int i = numberAsCharArray.Length - 1; i >= 0; i--)
            {
                reversedNumber += numberAsCharArray[i];
            }
            return reversedNumber;
        }
    }
}
