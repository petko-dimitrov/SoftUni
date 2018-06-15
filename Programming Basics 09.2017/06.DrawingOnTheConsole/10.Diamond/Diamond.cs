using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outsideDashes = 0;
            int insideDashes = 0;

            if (n % 2 == 0)
            {
                outsideDashes = n / 2 - 1;
                Console.Write(new string('-', outsideDashes));
                Console.Write("**");
                Console.Write(new string('-', outsideDashes));
                Console.WriteLine();
                outsideDashes--;
                insideDashes = 2;
                for (int row = 1; row <= (n - 2) / 2; row++)
                {                    
                    Console.Write(new string('-', outsideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', insideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', outsideDashes));
                    Console.WriteLine();
                    outsideDashes--;
                    insideDashes += 2;
                }
                outsideDashes++;
                insideDashes -= 2;
                for (int row = 1; row <= n / 2 - 1; row++)
                {
                    outsideDashes++;
                    insideDashes -= 2;
                    Console.Write(new string('-', outsideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', insideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', outsideDashes));
                    Console.WriteLine();                    
                }
            }
            else
            {
                outsideDashes = n / 2;
                Console.Write(new string('-', outsideDashes));
                Console.Write("*");
                Console.Write(new string('-', outsideDashes));
                Console.WriteLine();
                insideDashes = 1;
                outsideDashes--;
                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write(new string('-', outsideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', insideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', outsideDashes));
                    Console.WriteLine();
                    outsideDashes--;
                    insideDashes += 2;
                }
                outsideDashes++;
                insideDashes -= 2;
                for (int row = 1; row <= n / 2 - 1; row++)
                {
                    outsideDashes++;
                    insideDashes -= 2;
                    Console.Write(new string('-', outsideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', insideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', outsideDashes));
                    Console.WriteLine();
                }
                outsideDashes = n / 2;
                if (n != 1)
                {
                    Console.Write(new string('-', outsideDashes));
                    Console.Write("*");
                    Console.Write(new string('-', outsideDashes));
                    Console.WriteLine();
                }               
            }
        }
    }
}
