using System;

namespace _01.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int asterisks = 0;
            int spaces = n;

            for (int row = 1; row <= n + 1 ; row++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write(new string('*', asterisks));
                Console.Write(" | ");
                Console.Write(new string('*', asterisks));
                Console.Write(new string(' ', spaces));
                Console.WriteLine();
                spaces--;
                asterisks++;
            }
        }
    }
}
