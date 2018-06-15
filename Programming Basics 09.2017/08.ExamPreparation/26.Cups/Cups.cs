using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int cupsPlanned = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workdays = int.Parse(Console.ReadLine());

            double moneyPlanned = cupsPlanned * 4.2;
            int workHours = workdays * workers * 8;
            double cupsMade = Math.Floor(workHours / 5.0);
            double moneyMade = cupsMade * 4.2;

            if (moneyMade >= moneyPlanned )
            {
                Console.WriteLine("{0:f2} extra money", moneyMade - moneyPlanned);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", moneyPlanned - moneyMade);
            }
        }
    }
}
