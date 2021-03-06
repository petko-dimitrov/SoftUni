﻿using System;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    count++;

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations\r\n" +
                            $"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations\r\nSum: {sum}");
        }
    }
}
