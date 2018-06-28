using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' ', ',','?', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    builder.Append(word[i]);
                }
                if (builder.ToString() == word)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes.Distinct()));
        }
    }
}
