using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.EnterEvenNumberTryCatch
{
    class EnterEvenNumberTryCatch
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
