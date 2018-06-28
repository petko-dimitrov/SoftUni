using System;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSumMagic = false;

            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isSumMagic = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSumMagic}");
                sum = 0;
            }
        }
    }
}
