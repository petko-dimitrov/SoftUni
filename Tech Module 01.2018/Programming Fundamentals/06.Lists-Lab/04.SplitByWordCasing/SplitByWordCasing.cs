using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> upperCase = new List<string>(); 
            List<string> lowerCase = new List<string>(); 
            List<string> mixedCase = new List<string>();

            foreach (string word in words)
            {
                bool isUpper = true;
                bool isLower = true;
                foreach (char letter in word)
                {
                    if (letter < 'A' || letter > 'Z')
                    {
                        isUpper = false;
                    }
                    if (letter < 'a' || letter > 'z')
                    {
                        isLower = false;
                    }
                }
                if (isUpper)
                {
                    upperCase.Add(word);
                }
                else if (isLower)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
