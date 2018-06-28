using System;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int result = MultiplyCharacters(input);
            Console.WriteLine(result);
        }

        static int MultiplyCharacters(string[] input)
        {
            string word1 = input[0];
            string word2 = input[1];
            int length = Math.Min(word1.Length, word2.Length);
            int result = 0;

            for (int i = 0; i < length; i++)
            {
                result += word1[i] * word2[i];
            }

            if (word1.Length > word2.Length)
            {
                for (int i = length; i < word1.Length; i++)
                {
                    result += word1[i];
                }
            }
            else
            {
                for (int i = length; i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }
            return result;
        }
    }
}
