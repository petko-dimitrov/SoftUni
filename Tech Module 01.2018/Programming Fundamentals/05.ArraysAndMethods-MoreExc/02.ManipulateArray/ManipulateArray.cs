using System;
using System.Linq;

namespace _02.ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "Reverse")
                {
                    ReverseArray(words);
                }
                else if (command[0] == "Distinct")
                {
                    words = DeleteNonUnique(words);
                }
                else if (command[0] == "Replace")
                {
                    ReplaceElement(words, command);
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }

        static void ReplaceElement(string[] words, string[] command)
        {
            int index = int.Parse(command[1]);
            words[index] = command[2];
        }

        static string[] DeleteNonUnique(string[] words)
        {
            string[] uniqueWords = words.Distinct().ToArray();
            return uniqueWords;
        }

        static void ReverseArray(string[] words)
        {
            Array.Reverse(words);
        }
    }
}
