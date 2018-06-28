using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    AddToBook(command, phonebook);
                }
                else if (command[0] == "S")
                {
                    SearchBook(command, phonebook);
                }
                else if (command[0] == "ListAll")
                {
                    ListAll(phonebook);
                }
                command = Console.ReadLine().Split().ToList();
            }
        }

        static void ListAll(SortedDictionary<string, string> phonebook)
        {
            foreach (var number in phonebook)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }

        static void AddToBook(List<string> command, SortedDictionary<string, string> phonebook)
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

        static void SearchBook(List<string> command, SortedDictionary<string, string> phonebook)
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
    }
}