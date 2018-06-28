using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    int number = int.Parse(input[i].ToString());
                    numbers.Add(number);
                }
                catch (Exception)
                {
                    nonNumbers.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = "";
            int skipCount = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<char> taken = nonNumbers.Skip(skipCount).Take(takeList[i]).ToList();
                result += string.Join("", taken);
                skipCount += skipList[i] + takeList[i];
            }

            Console.WriteLine(result);
        }
    }
}
