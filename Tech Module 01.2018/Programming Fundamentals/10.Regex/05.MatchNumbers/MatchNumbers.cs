using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, regex).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
