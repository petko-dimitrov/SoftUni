using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOcurrences
{
    class OddOcurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ').ToArray();
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts[word] = 0;
                }
                wordCounts[word]++;
            }

            List<string> oddOcurrences = new List<string>();

            foreach (var count in wordCounts)
            {
                if (count.Value % 2 != 0)
                {
                    oddOcurrences.Add(count.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddOcurrences));
        }
    }
}
