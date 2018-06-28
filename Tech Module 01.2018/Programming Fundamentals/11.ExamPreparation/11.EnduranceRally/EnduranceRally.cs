using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpointIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<double> fuels = new List<double>();
            foreach (var name in drivers)
            {
                double fuel = name[0];
                fuels.Add(fuel);
            }

            for (int i = 0; i < drivers.Length; i++)
            {
                for (int j = 0; j < zones.Length; j++)
                {
                    if (checkpointIndexes.Contains(j))
                    {
                        fuels[i] += zones[j];
                    }
                    else
                    {
                        fuels[i] -= zones[j];
                    }
                    if (fuels[i] <= 0)
                    {
                        Console.WriteLine($"{drivers[i]} - reached {j}");
                        break;
                    }
                }

                if (fuels[i] > 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuels[i]:f2}");
                }
            }
        }
    }
}
