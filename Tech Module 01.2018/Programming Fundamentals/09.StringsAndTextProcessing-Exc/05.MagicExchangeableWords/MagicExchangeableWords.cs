using System;
using System.Collections.Generic;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string word1 = words[0];
            string word2 = words[1];

            if (word1.Length >= word2.Length)
            {
                if (CheckIfWordsAreExchangeable(word1, word2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                if (CheckIfWordsAreExchangeable(word2, word1))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool CheckIfWordsAreExchangeable(string word1, string word2)
        {
            bool areExchangeable = true;
            Dictionary<char, char> mappedChars = new Dictionary<char, char>();
            int length = word2.Length;

            for (int i = 0; i < length; i++)
            {
                if (!mappedChars.ContainsKey(word1[i]))
                {
                    mappedChars.Add(word1[i], word2[i]);
                }
                else if (mappedChars.ContainsKey(word1[i]) && mappedChars[word1[i]] != word2[i])
                {
                    areExchangeable = false;
                    return areExchangeable;
                }
            }

            for (int i = length; i < word1.Length; i++)
            {
                if (!mappedChars.ContainsKey(word1[i]))
                {
                    areExchangeable = false;
                }
            }

            return areExchangeable;
        }
    }
}
