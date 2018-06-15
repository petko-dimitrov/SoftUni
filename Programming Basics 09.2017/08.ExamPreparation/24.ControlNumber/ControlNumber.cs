using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int moves = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (sum >= control)
                {
                    break;
                }
                for (int j = m; j > 0; j--)
                {
                    sum += i * 2 + j * 3;
                    moves++;
                    if (sum >= control)
                    {
                        Console.WriteLine("{0} moves", moves);
                        Console.WriteLine("Score: {0} >= {1}", sum, control);
                        break;
                    }
                }
            }

            if (sum < control)
            {
                Console.WriteLine("{0} moves", moves);
            }
        }
    }
}
