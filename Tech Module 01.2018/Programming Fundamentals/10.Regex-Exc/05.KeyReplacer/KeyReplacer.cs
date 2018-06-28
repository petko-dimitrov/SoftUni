using System;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"([a-zA-Z]+)([\|\\<])";

            var first = Regex.Match(keyString, pattern).Groups[2].Index;
            var last = Regex.Match(keyString, pattern, RegexOptions.RightToLeft).Groups[2].Index;

            string start = "";
            string end = "";

            for (int i = 0; i < first; i++)
            {
                start += keyString[i];
            }
            for (int i = last + 1; i < keyString.Length; i++)
            {
                end += keyString[i];
            }

            pattern = $@"(?<={start})(.*?)(?={end})";
            string result = "";
            var matches = Regex.Matches(text, pattern);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    result += match.Value;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
