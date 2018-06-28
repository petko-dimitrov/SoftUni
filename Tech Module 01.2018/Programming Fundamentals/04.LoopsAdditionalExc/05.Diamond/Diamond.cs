using System;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine(new string('*', n));
                return;
            }

            int leftAsteriskPos = 0;
            int rightAsteriskPos = 0;

            if (n % 2 == 0)
            {
                leftAsteriskPos = n / 2 - 1;
                rightAsteriskPos = leftAsteriskPos + 3;
            }
            else
            {
                leftAsteriskPos = n / 2;
                rightAsteriskPos = leftAsteriskPos + 2;
            }

            PrintDiamondEdge(n);

            if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2 - 1; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == leftAsteriskPos || col == rightAsteriskPos)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    leftAsteriskPos--;
                    rightAsteriskPos++;
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 1; row <= n / 2; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == leftAsteriskPos || col == rightAsteriskPos)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    leftAsteriskPos--;
                    rightAsteriskPos++;
                    Console.WriteLine();
                }
            }

            leftAsteriskPos += 2;
            rightAsteriskPos -= 2;

            if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2 - 2; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == leftAsteriskPos || col == rightAsteriskPos)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    leftAsteriskPos++;
                    rightAsteriskPos--;
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 1; row <= n / 2 - 1; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == leftAsteriskPos || col == rightAsteriskPos)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    leftAsteriskPos++;
                    rightAsteriskPos--;
                    Console.WriteLine();
                }
            }

            PrintDiamondEdge(n);
        }

        static void PrintTopBody(int n, ref int leftAsteriskPos, ref int rightAsteriskPos)
        {
            
        }

        static void PrintDiamondEdge(int n)
        {
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n / 2 || i == n / 2 + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n / 2 + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
