using System;
using System.Linq;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
             
            int[] resultArr = new int[Math.Max(firstArr.Length, secondArr.Length)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(String.Join(" ", resultArr));
        }
    }
}
