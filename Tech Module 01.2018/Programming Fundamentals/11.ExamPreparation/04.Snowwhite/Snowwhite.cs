using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Dwarf> dwarves = new List<Dwarf>();
            Dictionary<string, int> colours = new Dictionary<string, int>();

            while (input != "Once upon a time")
            {
                string[] dwarfInfo = input
                    .Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                Dwarf currentDwarf = new Dwarf();
                currentDwarf.Name = dwarfInfo[0];
                currentDwarf.Colour = dwarfInfo[1];
                currentDwarf.Physics = long.Parse(dwarfInfo[2]);
                bool shouldAddDwarf = true;

                for (int i = 0; i < dwarves.Count; i++)
                {
                    if (dwarves[i].Name == currentDwarf.Name && dwarves[i].Colour == currentDwarf.Colour)
                    {
                        if (dwarves[i].Physics < currentDwarf.Physics)
                        {
                            dwarves[i].Physics = currentDwarf.Physics;
                            shouldAddDwarf = false;
                        }
                    }
                }

                if (shouldAddDwarf)
                {
                    dwarves.Add(currentDwarf);

                    if (!colours.ContainsKey(currentDwarf.Colour))
                    {
                        colours.Add(currentDwarf.Colour, 1);
                    }
                    else
                    {
                        colours[currentDwarf.Colour]++;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarves.OrderByDescending(x => x.Physics)
                .ThenByDescending(x => colours[x.Colour]))
            {
                Console.WriteLine($"({dwarf.Colour}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    class Dwarf
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public long Physics { get; set; }
    }
}
