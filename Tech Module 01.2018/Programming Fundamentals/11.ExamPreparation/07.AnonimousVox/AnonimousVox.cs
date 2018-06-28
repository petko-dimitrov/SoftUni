using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.AnonimousVox
{
    class AnonimousVox
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string placeholders = Console.ReadLine();
            string pattern = @"(?<border>[A-Za-z]+)(?<value>.+)(\k<border>)";

            var matches = Regex.Matches(text, pattern);
            
            string[] values = placeholders.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> encodedText = new List<string>();

            foreach (Match match in matches)
            {
                encodedText.Add(match.Groups["value"].Value);
            }

            if (values.Length < encodedText.Count)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    text = ReplaceFirst(text, encodedText[i], values[i]);
                }
            }
            else
            {
                for (int i = 0; i < encodedText.Count; i++)
                {
                    text = ReplaceFirst(text, encodedText[i], values[i]); ;
                }
            }
            
            Console.WriteLine(text);
        }

        static string ReplaceFirst(string text, string oldValue, string newValue)
        {
            string old = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);

            string newVal = old.Replace(oldValue, newValue);

            return newVal + text.Substring(old.Length);
        }
    }
}
