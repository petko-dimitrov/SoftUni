using System;
using System.IO;
using System.Linq;

namespace _02.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];

            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(i + 97);
            }

            char[] input = File.ReadAllText("input.txt").ToCharArray();
            string[] charIndexes = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int index = 0;

                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[j] == input[i])
                    {
                        index = j;
                        break;
                    }
                }

                charIndexes[i] = $"{input[i]} -> {index}";
            }

            File.WriteAllLines("output.txt", charIndexes);
        }
    }
}
