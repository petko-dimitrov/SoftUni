using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _07.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<message>[^0-9]+)(?<count>[0-9]+)";

            var matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            StringBuilder sbUnique = new StringBuilder();


            foreach (Match match in matches)
            {
                string current = "";

                if (match.Groups["count"].Value != "0")
                {
                    current = match.Groups["message"].Value.ToUpper();
                    sbUnique.Append(current);
                }

                for (int i = 0; i < int.Parse(match.Groups["count"].Value); i++)
                {
                    sb.Append(current);
                }

            }
            
            int uniqueSymbols = sbUnique.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(sb);
        }
    }
}
