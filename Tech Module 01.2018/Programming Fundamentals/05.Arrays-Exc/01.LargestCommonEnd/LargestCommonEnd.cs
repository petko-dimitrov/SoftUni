using System;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            int shorterArrLength = Math.Min(firstArr.Length, secondArr.Length);
            int longerArrLength = Math.Max(firstArr.Length, secondArr.Length);
            int lengthDifference = Math.Max(firstArr.Length, secondArr.Length) - Math.Min(firstArr.Length, secondArr.Length);
            int counter = 0;
            int largestCommonEnd = 0;

            for (int i = 0; i < shorterArrLength; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            largestCommonEnd = counter;
            counter = 0;

            for (int i = longerArrLength - 1; i >= lengthDifference; i--)
            {
                if (firstArr.Length > secondArr.Length)
                {
                    if (firstArr[i] == secondArr[i - lengthDifference])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (firstArr[i - lengthDifference] == secondArr[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (counter > largestCommonEnd)
            {
                largestCommonEnd = counter;
            }
            Console.WriteLine(largestCommonEnd);
        }
    }
}
