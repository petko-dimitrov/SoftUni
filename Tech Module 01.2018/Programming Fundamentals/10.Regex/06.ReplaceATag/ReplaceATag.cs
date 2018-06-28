using System;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacePattern = @"[URL href=$1]$2[/URL]";
            string input = Console.ReadLine();

            while (input != "end")
            {
                string result = Regex.Replace(input, pattern, replacePattern);
                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
