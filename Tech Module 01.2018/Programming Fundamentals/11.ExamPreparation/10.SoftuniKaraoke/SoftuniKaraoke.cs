using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftuniKaraoke
{
    class SoftuniKaraoke
    {
        static void Main(string[] args)
        {
            List<string> contestants = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();

            string performance = Console.ReadLine();

            while (performance != "dawn")
            {
                string[] performanceInfo = performance.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = performanceInfo[0];
                string song = performanceInfo[1];
                string award = performanceInfo[2];

                if (contestants.Contains(name) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(name))
                    {
                        List<string> temp =new List<string> { award };
                        awards.Add(name, temp);
                    }
                    else if (!awards[name].Contains(award))
                    {
                        awards[name].Add(award);
                    }
                }

                performance = Console.ReadLine();
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var singer in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                foreach (var award in singer.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
