﻿using System;

namespace _11.DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ((b - a) < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = a; i <= b - 4; i++)
            {
                for (int j = a + 1; j <= b - 3; j++)
                {
                    for (int k = a + 2; k <= b - 2; k++)
                    {
                        for (int l = a + 3; l <= b - 1; l++)
                        {
                            for (int m = a + 4; m <= b; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
