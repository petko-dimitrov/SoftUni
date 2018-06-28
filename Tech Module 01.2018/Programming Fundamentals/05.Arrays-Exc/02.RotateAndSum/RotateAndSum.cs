using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int timesToRotate = int.Parse(Console.ReadLine());
            int[] sumArray = new int[numbers.Length];

            for (int i = 0; i < timesToRotate; i++)
            {
                numbers = RotateArray(numbers);
                for (int j = 0; j < sumArray.Length; j++)
                {
                    sumArray[j] += numbers[j];
                }
            }

            Console.WriteLine(String.Join(" ", sumArray));
        }

        static int[] RotateArray(int[] array)
        {
            int[] rotatedArray = new int[array.Length];
            rotatedArray[0] = array[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                rotatedArray[i] = array[i - 1];
            }

            return rotatedArray;
        }
    }
}
