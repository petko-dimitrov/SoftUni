using System;

namespace _01.X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstXPos = 1;
            int secondXPos = n;

            for (int row = 1; row <= n / 2; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (firstXPos == col || secondXPos == col)
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                firstXPos++;
                secondXPos--;
                Console.WriteLine();
            }

            Console.WriteLine("{0}x{0}", new string(' ', n / 2));

            for (int row = 1; row <= n / 2; row++)
            {
                firstXPos--;
                secondXPos++;
                for (int col = 1; col <= n; col++)
                {
                    if (firstXPos == col || secondXPos == col)
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
