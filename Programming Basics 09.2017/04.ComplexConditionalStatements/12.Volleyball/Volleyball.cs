using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double weekendsInSofia = 3.0 / 4 * (48 - h);
            double playVolley = weekendsInSofia + 2.0 / 3 * p + h;
            switch (yearType)
            {
                case "leap":
                    Console.WriteLine(Math.Floor(playVolley * 1.15));
                    break;
                case "normal":
                    Console.WriteLine(Math.Floor(playVolley));
                    break;
                default:
                    break;
            }
        }
    }
}
