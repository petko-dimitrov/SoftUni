using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine("{ " + String.Join(", ", ExtractMiddleIntegers(numbers)) + " }");
        }

        static int[] ExtractMiddleIntegers(int[] arr)
        {
            if (arr.Length == 1)
            {
                int[] middleElements = arr;
                return middleElements;
            }
            else if (arr.Length % 2 == 0)
            {
                int[] middleElements = new int[2];
                for (int i = 0; i < middleElements.Length; i++)
                {
                    middleElements[i] = arr[arr.Length / 2 - 1 + i];
                }
                return middleElements;
            }
            else
            {
                int[] middleElements = new int[3];
                for (int i = 0; i < middleElements.Length; i++)
                {
                    middleElements[i] = arr[arr.Length / 2 - 1 + i];
                }
                return middleElements;
            }
        }
    }
}
