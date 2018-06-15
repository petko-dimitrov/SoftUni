using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            string oddOrEven = " - odd";
            double result = 0.0;
            string resultString = $"{n1} {symbol} {n2} = ";

            if (symbol == '+')
            {
                result = n1 + n2;                                
            }
            else if (symbol == '-')
            {
                result = n1 - n2;
            }
            else if (symbol == '*')
            {
                result = n1 * n2;
            }
            else if (symbol == '/' && n2 != 0)
            {
                result = (double)n1 / n2;
            }
            else if (symbol == '%' && n2 != 0)
            {
                result = n1 % n2;
            }
            if (result % 2 == 0)
            {
                oddOrEven = " - even";
            }
            resultString += result;
            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                Console.WriteLine(resultString + oddOrEven);
            }
            else if ((symbol == '/' || symbol == '%') && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (symbol == '/')
            {
                Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, result);
            }
            else
            {
                Console.WriteLine(resultString);
            }
        }
    }
}
