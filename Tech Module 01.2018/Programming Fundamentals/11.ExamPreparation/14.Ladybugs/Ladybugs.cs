using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int[] ladybugs = new int[size];

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] >= 0 && indexes[i] < ladybugs.Length)
                {
                    ladybugs[indexes[i]] = 1;
                }
            }

            while (command[0] != "end")
            {
                int index = int.Parse(command[0]);
                if (index < 0 || index >= ladybugs.Length)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }
                int distance = int.Parse(command[2]);

                if (ladybugs[index] == 1)
                {
                    int indexToLand = 0;
                    ladybugs[index] = 0;
                    indexToLand = CalculateIndexToLand(command, index, distance);

                    while (true)
                    {
                        if (indexToLand < 0 || indexToLand >= ladybugs.Length)
                        {
                            break;
                        }
                        else if (ladybugs[indexToLand] == 0)
                        {
                            ladybugs[indexToLand] = 1;
                            break;
                        }
                        else
                        {
                            indexToLand = CalculateIndexToLand(command, indexToLand, distance);
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        static int CalculateIndexToLand(string[] command, int index, int distance)
        {
            int indexToLand = 0;
            if (command[1] == "left")
            {
                indexToLand = index - distance;
            }
            else
            {
                indexToLand = index + distance;
            }

            return indexToLand;
        }
    }
}
