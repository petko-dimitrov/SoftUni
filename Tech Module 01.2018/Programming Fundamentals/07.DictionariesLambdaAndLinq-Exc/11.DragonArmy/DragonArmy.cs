using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, double[]>> dragons
                = new Dictionary<string, Dictionary<string, double[]>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string typeOfDragon = input[0];
                string dragonName = input[1];
                double[] dragonStats = new double[3];
                ReadDragonStats(input, dragonStats);
                Dictionary<string, double[]> currentDragon = new Dictionary<string, double[]>();
                currentDragon.Add(dragonName, dragonStats);

                if (!dragons.ContainsKey(typeOfDragon))
                {
                    dragons.Add(typeOfDragon, currentDragon);
                }
                else if (!dragons[typeOfDragon].ContainsKey(dragonName))
                {
                    dragons[typeOfDragon].Add(dragonName, dragonStats);
                }
                else
                {
                    dragons[typeOfDragon][dragonName] = dragonStats;
                }
            }

            foreach (var dragonType in dragons)
            {
                double avgDamage = 0;
                double avgHealth = 0;
                double avgArmor = 0;
                int count = 0;
                foreach (var dragon in dragonType.Value)
                {
                    avgDamage += dragon.Value[0];
                    avgHealth += dragon.Value[1];
                    avgArmor += dragon.Value[2];
                    count++;
                }
                avgDamage /= count;
                avgHealth /= count;
                avgArmor /= count;
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", dragonType.Key, avgDamage, avgHealth, avgArmor);
                foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}," +
                        $" health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

        static void ReadDragonStats(string[] input, double[] dragonStats)
        {
            for (int j = 0; j < dragonStats.Length; j++)
            {
                if (input[j + 2] != "null")
                {
                    dragonStats[j] = double.Parse(input[j + 2]);
                }
                else
                {
                    switch (j)
                    {
                        case 0:
                            dragonStats[j] = 45;
                            break;
                        case 1:
                            dragonStats[j] = 250;
                            break;
                        case 2:
                            dragonStats[j] = 10;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
