using System;
using System.Linq;
using System.Text;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            int lengthDifference = Math.Abs(firstNum.Length - secondNum.Length);

            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            string result = SumNumbers(firstNum, secondNum);
            StringBuilder reversed = ReverseSum(result);

            Console.WriteLine(reversed);
        }

        static StringBuilder ReverseSum(string result)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reversed.Append(result[i]);
            }

            return reversed;
        }

        static string SumNumbers(string firstNum, string secondNum)
        {
            StringBuilder builder = new StringBuilder();
            bool remainderLeft = false;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int firstNumCurrentDigit = int.Parse(firstNum[i].ToString());
                int secondNumCurrentDigit = int.Parse(secondNum[i].ToString());
                if (remainderLeft)
                {
                    firstNumCurrentDigit++;
                    remainderLeft = false;
                }
                int currentSum = firstNumCurrentDigit + secondNumCurrentDigit;
                if (currentSum < 10)
                {
                    builder.Append(currentSum);
                }
                else
                {
                    builder.Append((currentSum - 10).ToString());
                    remainderLeft = true;
                }
            }

            if (remainderLeft)
            {
                builder.Append(1);
            }

            string result = builder.ToString().TrimEnd('0');
            return result;
        }
    }
}