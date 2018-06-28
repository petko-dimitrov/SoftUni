using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            while (numbers.Contains(bombNumber))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bombNumber && i - bombPower < 0 && i + bombPower > numbers.Count - 1)
                    {
                        numbers.Clear();
                    }
                    else if (numbers[i] == bombNumber && i + bombPower > numbers.Count - 1)
                    {
                        numbers.RemoveRange(i, numbers.Count - i);
                        numbers.RemoveRange(i - bombPower, bombPower);
                    }
                    else if (numbers[i] == bombNumber && i - bombPower < 0)
                    {
                        numbers.RemoveRange(i, bombPower + 1);
                        numbers.RemoveRange(0, i);
                    }
                    else if (numbers[i] == bombNumber)
                    {
                        numbers.RemoveRange(i - bombPower, 2 * bombPower + 1);
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
