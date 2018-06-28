using System;

namespace _02.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int wingSymbol = n - 2;

            for (int row = 1; row <= height / 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.Write(new string('-', wingSymbol));
                    Console.Write("\\ /");
                    Console.Write(new string('-', wingSymbol));
                }
                else
                {
                    Console.Write(new string('*', wingSymbol));
                    Console.Write("\\ /");
                    Console.Write(new string('*', wingSymbol));
                }
                Console.WriteLine();
            }

            Console.WriteLine($"{new string(' ', width / 2)}@{ new string(' ', width / 2)}");

            for (int row = 1; row <= height / 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.Write(new string('-', wingSymbol));
                    Console.Write("/ \\");
                    Console.Write(new string('-', wingSymbol));
                }
                else
                {
                    Console.Write(new string('*', wingSymbol));
                    Console.Write("/ \\");
                    Console.Write(new string('*', wingSymbol));
                }
                Console.WriteLine();
            }
        }
    }
}
