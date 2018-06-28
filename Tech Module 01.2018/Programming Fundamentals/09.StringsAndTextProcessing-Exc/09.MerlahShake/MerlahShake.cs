using System;
using System.Text.RegularExpressions;

namespace _09.MerlahShake
{
    class MerlahShake
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            string pattern = Console.ReadLine();
            string regex = Regex.Escape(pattern);
            bool isShake = true;

            while (isShake)
            {
                var matches = Regex.Matches(sequence, regex);
                if (matches.Count > 1)
                {
                    Console.WriteLine("Shaked it.");
                    var lastIndex = Regex.Match(sequence, regex, RegexOptions.RightToLeft).Index;
                    var firstIndex = Regex.Match(sequence, regex).Index;
                    sequence = sequence.Remove(lastIndex, pattern.Length);
                    sequence = sequence.Remove(firstIndex, pattern.Length);
                    if (pattern.Length > 1)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                        regex = Regex.Escape(pattern);
                    }
                    else
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(sequence);
                        isShake = false;
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(sequence);
                    isShake = false;
                }
            }               
        }
    }
}
