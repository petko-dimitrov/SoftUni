using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    DeleteElements(numbers, command);
                }
                else if (command[0] == "Insert")
                {
                    InsertElement(numbers, command);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            if (command[0] == "Odd")
            {
                PrintOddNumbers(numbers);
            }
            else if (command[0] == "Even")
            {
                PrintEvenNumbers(numbers);
            }
        }

        static void PrintOddNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }
            }
        }

        static void PrintEvenNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
        }

        static void InsertElement(List<int> numbers, List<string> command)
        {
            int index = int.Parse(command[2]);
            int element = int.Parse(command[1]);
            numbers.Insert(index, element);
        }

        static void DeleteElements(List<int> numbers, List<string> command)
        {
            int elementToRemove = int.Parse(command[1]);
            
            //shorter way 
            //numbers.RemoveAll(n => n == elementToRemove);

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    if (numbers[j] == elementToRemove)
                    {
                        numbers.Remove(numbers[j]);
                        break;
                    }
                }
            }
        }
    }
}
