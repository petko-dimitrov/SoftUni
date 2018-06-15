using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
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
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
