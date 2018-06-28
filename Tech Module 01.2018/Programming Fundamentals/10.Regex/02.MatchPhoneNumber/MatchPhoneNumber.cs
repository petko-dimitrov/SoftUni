using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(?<delimiter>[-|\s])2\k<delimiter>\d{3}\k<delimiter>\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            var matchedPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
