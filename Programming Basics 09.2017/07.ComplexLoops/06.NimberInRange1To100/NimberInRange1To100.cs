using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NimberInRange1To100
{
    class NimberInRange1To100
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100 )
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
