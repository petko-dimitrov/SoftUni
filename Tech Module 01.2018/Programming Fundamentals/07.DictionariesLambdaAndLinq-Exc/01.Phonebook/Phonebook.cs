using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook[command[1]] = command[2];
                    }
                    else
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                }
                else if (command[0] == "S")
                {
                    bool numberFound = false;
                    foreach (var number in phonebook)
                    {
                        if (number.Key == command[1])
                        {
                            Console.WriteLine($"{number.Key} -> {number.Value}");
                            numberFound = true;
                        }
                    }
                    if (!numberFound)
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
        }
    }
}
