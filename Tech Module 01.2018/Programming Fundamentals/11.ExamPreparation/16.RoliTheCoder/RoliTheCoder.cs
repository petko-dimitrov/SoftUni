using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, string> eventIds = new Dictionary<int, string>();
            Dictionary<string, List<string>> events = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {
                string[] eventInfo = input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(eventInfo[0]);

                string name = eventInfo[1];

                if (!name.StartsWith("#"))
                {
                    input = Console.ReadLine();
                    continue;
                }

                name = name.Trim('#');            
                List<string> participants = new List<string>();
                bool namesAreValid = true;

                for (int i = 2; i < eventInfo.Length; i++)
                {
                    if (!eventInfo[i].StartsWith("@"))
                    {
                        namesAreValid = false;
                        break;
                    }
                }

                if (namesAreValid)
                {
                    for (int i = 2; i < eventInfo.Length; i++)
                    {
                        participants.Add(eventInfo[i]);
                    }
                }

                if (!eventIds.ContainsKey(id))
                {
                    eventIds.Add(id, name);
                    events.Add(name, participants);
                    events[name] = events[name].Distinct().ToList();
                }

                else if (eventIds.ContainsKey(id))
                {
                    if (eventIds[id] == name)
                    {
                        events[name].AddRange(participants);
                        events[name] = events[name].Distinct().ToList();
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var eventName in events.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventName.Key} - {eventName.Value.Count}");

                foreach (var participant in eventName.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }

    }
}
