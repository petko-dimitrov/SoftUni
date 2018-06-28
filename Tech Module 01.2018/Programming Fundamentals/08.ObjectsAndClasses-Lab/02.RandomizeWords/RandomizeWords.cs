using System;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int index = rand.Next(0, words.Length);
                words[i] = words[index];
                words[index] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
