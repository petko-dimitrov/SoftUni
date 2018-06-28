using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> legions = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> activities = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                int lastActivity = int.Parse(data[0]);
                string legionName = data[1];
                string soldierType = data[2];
                long soldierCount = long.Parse(data[3]);
                Dictionary<string, long> currentSoldier = new Dictionary<string, long>();
                currentSoldier.Add(soldierType, soldierCount);

                if (!legions.ContainsKey(legionName))
                {
                    legions.Add(legionName, currentSoldier);
                    activities.Add(legionName, lastActivity);
                }
                else
                {
                    if (!legions[legionName].ContainsKey(soldierType))
                    {
                        legions[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        legions[legionName][soldierType] += soldierCount;
                    }

                    if (activities[legionName] < lastActivity)
                    {
                        activities[legionName] = lastActivity;
                    }
                }
            }

            string[] printCommand = Console.ReadLine().Split('\\');

            if (printCommand.Length > 1)
            {
                int activity = int.Parse(printCommand[0]);
                string type = printCommand[1];

                var selectedLegions = legions.Where(x => activities[x.Key] < activity);
                Dictionary<string, long> legionsToPrint = new Dictionary<string, long>();

                foreach (var legion in selectedLegions.Where(x => x.Value.ContainsKey(type)))
                {
                    foreach (var soldierType in legion.Value.Where(x => x.Key == type))
                    {
                        legionsToPrint.Add(legion.Key, soldierType.Value);
                    }
                }

                foreach (var pair in legionsToPrint.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }

            else
            {
                string type = printCommand[0];

                foreach (var pair in activities.OrderByDescending(x => x.Value))
                {
                    if (legions[pair.Key].ContainsKey(type))
                    {
                        Console.WriteLine($"{pair.Value} : {pair.Key}");
                    }
                }
            }
        }
    }
}
