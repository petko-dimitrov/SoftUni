using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.MoneyPrize
{
    class MoneyPrize
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double prizePerPoint = double.Parse(Console.ReadLine());
            double totalPrize = 0.0;

            for (int i = 1; i <= projectParts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    totalPrize += points * 2 * prizePerPoint;
                }
                else
                {
                    totalPrize += points * prizePerPoint;
                }
            }
            Console.WriteLine("The project prize was {0:f2} lv.", totalPrize);
        }
    }
}
