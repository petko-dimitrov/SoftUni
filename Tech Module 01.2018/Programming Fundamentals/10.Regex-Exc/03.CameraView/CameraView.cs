using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int symbolsToSkip = numbers[0];
            int symbolsToTake = numbers[1];
            string pattern = @"(\|<)(\w{" + symbolsToSkip + @"})(\w{0," + symbolsToTake + @"})";

            var matches = Regex.Matches(input, pattern);
            List<string> takenWords = new List<string>();

            foreach (Match match in matches)
            {
                takenWords.Add(match.Groups[3].Value);
            }

            Console.WriteLine(string.Join(", ", takenWords));
        }
    }
}
