using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberToText
{
    class NumberToText
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string rightDigit = "";
            string leftDigit = "";
            if (num < 10)
            {
                if (num == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (num == 1)
                {
                    Console.WriteLine("one");
                }
                else if (num == 2)
                {
                    Console.WriteLine("two");
                }
                else if (num == 3)
                {
                    Console.WriteLine("three");
                }
                else if (num == 4)
                {
                    Console.WriteLine("four");
                }
                else if (num == 5)
                {
                    Console.WriteLine("five");
                }
                else if (num == 6)
                {
                    Console.WriteLine("six");
                }
                else if (num == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (num == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (num == 9)
                {
                    Console.WriteLine("nine");
                }
            }
            if (num >= 10 && num < 20)
            {
                if (num == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (num == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (num == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (num == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (num == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (num == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (num == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (num == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (num == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (num == 19)
                {
                    Console.WriteLine("nineteen");
                }
            }
            if (num >= 20 && num < 100)
            {
                if (num / 10 == 2)
                {
                    leftDigit = "twenty";
                }
                else if (num / 10 == 3)
                {
                    leftDigit = "thirty";
                }
                else if (num / 10 == 4)
                {
                    leftDigit = "forty";
                }
                else if (num / 10 == 5)
                {
                    leftDigit = "fifty";
                }
                else if (num / 10 == 6)
                {
                    leftDigit = "sixty";
                }
                else if (num / 10 == 7)
                {
                    leftDigit = "seventy";
                }
                else if (num / 10 == 8)
                {
                    leftDigit = "eighty";
                }
                else if (num / 10 == 9)
                {
                    leftDigit = "ninety";
                }
                if (num % 10 == 0)
                {
                    Console.WriteLine(leftDigit);
                }
                else if (num % 10 == 1)
                {
                    rightDigit = "one";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 2)
                {
                    rightDigit = "two";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 3)
                {
                    rightDigit = "three";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 4)
                {
                    rightDigit = "four";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 5)
                {
                    rightDigit = "five";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 6)
                {
                    rightDigit = "six";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 7)
                {
                    rightDigit = "seven";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 8)
                {
                    rightDigit = "eight";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }
                else if (num % 10 == 9)
                {
                    rightDigit = "nine";
                    Console.WriteLine(leftDigit + " " + rightDigit);
                }                
            }
            if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            if (num < 0 || num > 100)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
