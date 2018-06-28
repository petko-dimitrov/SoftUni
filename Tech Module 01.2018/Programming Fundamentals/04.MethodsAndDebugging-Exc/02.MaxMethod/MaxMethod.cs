using System;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int maxNum = GetMax(firstNum, secondNum);
            maxNum = GetMax(maxNum, thirdNum);
            Console.WriteLine(maxNum);
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = 0;
            if (firstNumber > secondNumber)
            {
                maxNumber = firstNumber;
            }
            else
            {
                maxNumber = secondNumber;
            }
            return maxNumber;
        }
    }
}
