using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<key>[^&?]+)=(?<value>[^&?]+)";
            string replacePattern = @"%20|\+";

            while (input != "END")
            {
                Dictionary<string, string> pairs = new Dictionary<string, string>();
                var matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string key = match.Groups["key"].Value;
                    string value = match.Groups["value"].Value;
                    key = Regex.Replace(key, replacePattern, " ").Trim();
                    value = Regex.Replace(value, replacePattern, " ").Trim();
                    key = Regex.Replace(key, @"\s+|\n+", " ");
                    value = Regex.Replace(value, @"\s+|\n+", " ");

                    if (!pairs.ContainsKey(key))
                    {
                        pairs.Add(key, value);
                    }
                    else 
                    {
                        pairs[key] += ", " + value; 
                    }
                }

                foreach (var pair in pairs)
                {
                    Console.Write($"{pair.Key}=[{pair.Value}]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }

        }
    }
}
