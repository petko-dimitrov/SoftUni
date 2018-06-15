using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Lutenitsa
    {
        static void Main(string[] args)
        {
            double tomatoes = double.Parse(Console.ReadLine());
            int casettesPerTruck = int.Parse(Console.ReadLine());
            int jarsPerCasette = int.Parse(Console.ReadLine());

            int jarsPerTruck = casettesPerTruck * jarsPerCasette;
            double totalLutenitsa = tomatoes / 5.0;
            double fullJars = totalLutenitsa / 0.535;
            double fullCasettes = fullJars / jarsPerCasette;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitsa));

            if (fullCasettes > casettesPerTruck)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(fullCasettes - casettesPerTruck));
                Console.WriteLine("{0} jars left.", Math.Floor(fullJars - jarsPerTruck));
            }
            else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(casettesPerTruck - fullCasettes));
                Console.WriteLine("{0} more jars needed.", Math.Floor(jarsPerTruck - fullJars));
            }

        }
    }
}
