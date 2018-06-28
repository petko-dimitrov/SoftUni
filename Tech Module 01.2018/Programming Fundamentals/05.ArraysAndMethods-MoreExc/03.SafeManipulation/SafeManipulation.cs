using System;
using System.Linq;

namespace _03.SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string[] command = new string[3];

            while (command[0] != "END")
            {
                command = Console.ReadLine().Split(' ');
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
                else if (command[0] == "END")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid input!"); ;
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }

        static void ReplaceElement(string[] words, string[] command)
        {
            int index = int.Parse(command[1]);
            if (index >= 0 && index < words.Length)
            {
                words[index] = command[2];
            }
            else
            {
                Console.WriteLine("Invalid input!"); ;
            }
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
