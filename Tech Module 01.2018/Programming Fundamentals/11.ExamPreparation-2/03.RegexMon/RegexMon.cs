using System;
using System.Text.RegularExpressions;

namespace _03.RegexMon
{
    class RegexMon
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";
            string didiPattern = @"[^A-Za-z\-]+";

            int counter = 1;
            int index = 0;

            while (true)
            {
                if (counter % 2 != 0)
                {
                    if (Regex.IsMatch(text, didiPattern))
                    {
                        string match = Regex.Match(text, didiPattern).Value;
                        Console.WriteLine(match);
                        index = text.IndexOf(match);
                        text = text.Remove(0, index + match.Length);
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                else
                {
                    if (Regex.IsMatch(text, bojoPattern))
                    {
                        string match = Regex.Match(text, bojoPattern).Value;
                        Console.WriteLine(match);
                        index = text.IndexOf(match);
                        text = text.Remove(0, index + match.Length);
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
