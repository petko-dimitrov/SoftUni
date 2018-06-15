using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int dashes = 2 * n + 1;
            int rows = 2 * n + 2;

            // First row
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', dashes));
            dots--;
            dashes -= 2;

            // Upper half
            for (int i = dots; i > 0; i--)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', dashes));
                dots--;
                dashes += 2;
            }
            dashes -= 5;
            // Stop
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', dashes / 2));
            dashes += 5;

            // Bottom half
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', dashes));
                dots++;
                dashes -= 2;
            }
        }
    }
}
