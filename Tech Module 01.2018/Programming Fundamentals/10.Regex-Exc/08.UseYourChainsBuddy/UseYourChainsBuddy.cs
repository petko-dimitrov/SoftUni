using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=<p>).*?(?=<\/p>)";
            string replacePattern = @"([^a-z0-9])";

            var matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match);
            }

            string result = sb.ToString();
            result = Regex.Replace(result, replacePattern, " ");
            result = Regex.Replace(result, @"\s+|\n+", " ");
            sb.Clear();

            foreach (char ch in result)
            {
                if (ch >= 'a' && ch <= 'm')
                {
                    sb.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    sb.Append((char)(ch - 13));
                }
                else
                {
                    sb.Append(ch);
                }
            }

            result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
