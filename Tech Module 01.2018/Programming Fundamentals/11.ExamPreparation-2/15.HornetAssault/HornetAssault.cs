using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            long summedPower = hornets.Sum();


            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                if (summedPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= summedPower;
                    summedPower -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
