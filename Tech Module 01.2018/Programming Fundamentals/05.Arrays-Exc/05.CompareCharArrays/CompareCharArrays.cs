using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool differenceFound = false;
            bool firstArrIsEarlier = false;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    differenceFound = true;
                    firstArrIsEarlier = true;
                    break;
                }
                else if (secondArray[i] < firstArray[i])
                {
                    differenceFound = true;
                    break;
                }
            }

            if (!differenceFound)
            {
                if (firstArray.Length < secondArray.Length)
                {
                    firstArrIsEarlier = true;
                }
            }

            if (firstArrIsEarlier)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
        }
    }
}
