using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GrandpaStavri
{
    class GrandpaStavri
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalLiters = 0.0;
            double sumDegrees = 0.0;

            for (int i = 0; i < days; i++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                totalLiters += liters;
                sumDegrees += degrees * liters;
            }

            double finalDegrees = sumDegrees / totalLiters;
            Console.WriteLine("Liter: {0:f2}", totalLiters);
            Console.WriteLine("Degrees: {0:f2}", finalDegrees);
            if (finalDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (finalDegrees >= 38 && finalDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
