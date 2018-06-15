using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string upperBody = "\\ /";
            string bottomBody = "/ \\";
            int wingSize = n - 2;
            int rows = 2 * (n - 2) + 1;
            char symbol = ' ';

            for (int i = 1; i <= rows; i++)
            {
                if (i % 2 == 0)
                {
                    symbol = '-';
                }
                else
                {
                    symbol = '*';
                }
                if (i <= rows / 2)
                {
                    Console.Write(new string(symbol, wingSize));
                    Console.Write(upperBody);
                    Console.WriteLine(new string(symbol, wingSize));
                }
                else if (i <= rows / 2)
                {
                    Console.Write(new string(symbol, wingSize));
                    Console.Write(upperBody);
                    Console.WriteLine(new string(symbol, wingSize));
                }
                else if (i == rows / 2 + 1)
                {
                    Console.Write(new string(' ', wingSize + 1));
                    Console.Write("@");
                    Console.WriteLine(new string(' ', wingSize + 1));
                }
                else
                {
                    Console.Write(new string(symbol, wingSize));
                    Console.Write(bottomBody);
                    Console.WriteLine(new string(symbol, wingSize));
                }
            }
        }
    }
}
