using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {           
            string[] input = Console.ReadLine().Split();
            Dictionary<string, Dictionary<string, int>> venueConcerts = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "End")
            {
                int ticketsPrice = 0;
                int ticketsCount = 0;
                try
                {
                    ticketsPrice = int.Parse(input[input.Length - 2]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine().Split();
                    continue;
                }
                try
                {
                    ticketsCount = int.Parse(input[input.Length - 1]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine().Split();
                    continue;
                }
                string name = "";
                string venue = "";
                ReadNameAndVenue(input, ref name, ref venue);
                AddConcertInfo(venueConcerts, ticketsPrice, ticketsCount, name, venue);
                input = Console.ReadLine().Split();
            }

            foreach (var pair in venueConcerts)
            {
                Console.WriteLine(pair.Key);
                foreach (var singer in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        static void AddConcertInfo(Dictionary<string, Dictionary<string, int>> venueConcerts, int ticketsPrice, int ticketsCount, string name, string venue)
        {
            if (name != "" && venue != "")
            {
                int profit = ticketsCount * ticketsPrice;
                Dictionary<string, int> currentConcert = new Dictionary<string, int>();
                currentConcert.Add(name, profit);
                if (!venueConcerts.ContainsKey(venue))
                {
                    venueConcerts.Add(venue, currentConcert);
                }
                else if (!venueConcerts[venue].ContainsKey(name))
                {
                    venueConcerts[venue].Add(name, profit);
                }
                else
                {
                    venueConcerts[venue][name] += profit;
                }
            }
        }

        static void ReadNameAndVenue(string[] input, ref string name, ref string venue)
        {
            bool nameAdded = false;

            for (int i = 0; i < input.Length - 2; i++)
            {
                if (!nameAdded && !input[i].Any(x => (x < 65 || (x > 90 && x < 97) || x > 122)))
                {
                    name += input[i] + " ";
                }
                else if (input[i].StartsWith("@"))
                {
                    venue += input[i] + " ";
                    nameAdded = true;
                }
                else if (!input[i].Any(x => (x < 65 || (x > 90 && x < 97) || x > 122)))
                {
                    venue += input[i] + " ";
                }
            }
            name = name.TrimEnd();
            venue = venue.TrimStart('@');
        }
    }
}