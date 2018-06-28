using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        AddElement(numbers, command);
                        break;
                    case "addMany":
                        AddManyElements(numbers, command);
                        break;
                    case "contains":
                        CheckIfContains(numbers, command);
                        break;
                    case "remove":
                        RemoveElement(numbers, command);
                        break;
                    case "shift":
                        numbers = ShiftElements(numbers, command);
                        break;
                    case "sumPairs":
                        SumPairs(numbers);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        static void SumPairs(List<int> numbers)
        {
            int cycles = numbers.Count / 2;
            
            for (int i = 0; i < cycles; i++)
            {
                numbers[i] = numbers[i] + numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        static List<int> ShiftElements(List<int> numbers, List<string> command)
        {
            int position = int.Parse(command[1]);
            List<int> shifted = new List<int>();
            for (int i = position % numbers.Count; i < numbers.Count; i++)
            {
                shifted.Add(numbers[i]);
            }
            for (int i = 0; i < position % numbers.Count; i++)
            {
                shifted.Add(numbers[i]);
            }
            numbers = shifted;
            return numbers;
        }

        static void RemoveElement(List<int> numbers, List<string> command)
        {
            int index = int.Parse(command[1]);
            numbers.RemoveAt(index);
        }

        static void CheckIfContains(List<int> numbers, List<string> command)
        {
            int numberToFind = int.Parse(command[1]);
            if (numbers.Contains(numberToFind))
            {
                Console.WriteLine(numbers.IndexOf(numberToFind));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static void AddManyElements(List<int> numbers, List<string> command)
        {
            int index = int.Parse(command[1]);
            List<int> numbersToAdd = new List<int>();
            for (int i = 2; i < command.Count; i++)
            {
                int currentNum = int.Parse(command[i]);
                numbersToAdd.Add(currentNum);
            }
            numbers.InsertRange(index, numbersToAdd);
        }

        static void AddElement(List<int> numbers, List<string> command)
        {
            int index = int.Parse(command[1]);
            int element = int.Parse(command[2]);
            numbers.Insert(index, element);
        }
    }
}
