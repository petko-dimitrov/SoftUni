using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.EnergyLoss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            double energyLoss = 0.0;

            for (int i = 1; i <= trainingDays; i++)
            {
                int trainingHours = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && trainingHours % 2 == 0)
                {
                    energyLoss += 68 * dancers;
                }
                else if (i % 2 != 0 && trainingHours % 2 == 0)
                {
                    energyLoss += 49 * dancers;
                }
                else if (i % 2 == 0 && trainingHours % 2 != 0)
                {
                    energyLoss += 65 * dancers;
                }
                else
                {
                    energyLoss += 30 * dancers;
                }
            }

            int totalEnergy = trainingDays * dancers * 100;
            double energyLeft = totalEnergy - energyLoss;
            double avgEnergyLeft = energyLeft / dancers / trainingDays;
            if (avgEnergyLeft <= 50)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", avgEnergyLeft);
            }
            else
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", avgEnergyLeft);
            }
        }
    }
}
