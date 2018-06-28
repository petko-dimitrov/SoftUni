using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (snowmen.Count > 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    List<int> aliveSnowmnen = snowmen.FindAll(x => x >= 0);
                    if (aliveSnowmnen.Count == 1)
                    {
                        break;
                    }
                    int attacker = i;
                    int target = snowmen[i];

                    if (snowmen[attacker] < 0)
                    {
                        continue;
                    }
                    if (target >= snowmen.Count)
                    {
                        target = target % snowmen.Count;
                    }
                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        snowmen[attacker] = -1;
                        continue;
                    }

                    int difference = Math.Abs(attacker - target);

                    if (difference % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        snowmen[target] = -1;
                    }
                    else 
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        snowmen[attacker] = -1;
                    }
                }

                List<int> temp = new List<int>();
                for (int j = 0; j < snowmen.Count; j++)
                {
                    if (snowmen[j] >= 0)
                    {
                        temp.Add(snowmen[j]);
                    }
                }
                snowmen = temp;
            }
        }
    }
}
