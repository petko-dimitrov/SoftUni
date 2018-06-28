using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderOrFooter(n);
            PrintBody(n);
            PrintHeaderOrFooter(n);
        }

        static void PrintHeaderOrFooter(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }

        static void PrintBody(int number)
        {
            for (int row = 0; row < number - 2; row++)
            {
                Console.Write('-');
                for (int col = 0; col < number - 1; col++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');         
            }
        }
    }
}
