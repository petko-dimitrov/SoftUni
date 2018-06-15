using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());
            double sectorA = 0.0;
            double sectorB = 0.0;
            double sectorV = 0.0;
            double sectorG = 0.0;

            for (int i = 0; i < totalFans; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                switch (sector)
                {
                    case 'A': sectorA++; break;
                    case 'B': sectorB++; break;
                    case 'V': sectorV++; break;
                    case 'G': sectorG++; break;
                    default:
                        break;
                }
            }

            Console.WriteLine("{0:f2}%", sectorA / totalFans * 100);
            Console.WriteLine("{0:f2}%", sectorB / totalFans * 100);
            Console.WriteLine("{0:f2}%", sectorV / totalFans * 100);
            Console.WriteLine("{0:f2}%", sectorG / totalFans * 100);
            Console.WriteLine("{0:f2}%", (double)totalFans / stadiumCapacity * 100);
        }
    }
}
