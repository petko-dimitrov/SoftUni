using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexNumbers
{
    class MatchHexNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            var hexNumbers = matches.Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", hexNumbers));
        }
    }
}
