using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "end")
            {
                if (command[0] == "reverse")
                {
                    Reverse(command, input);
                }
                else if (command[0] == "sort")
                {
                    Sort(command, input);
                }
                else if (command[0] == "rollLeft")
                {
                    RollLeft(command, input);
                }
                else if (command[0] == "rollRight")
                {
                    RollRight(command, input);
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("[" + string.Join(", ", input) + "]");

        }

        static void RollRight(string[] command, List<string> input)
        {
            int count = int.Parse(command[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            count = count % input.Count;

            for (int i = 0; i < count; i++)
            {
                string element = input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
                input.Insert(0, element);
            }

        }

        static void RollLeft(string[] command, List<string> input)
        {
            int count = int.Parse(command[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            count = count % input.Count;

            for (int i = 0; i < count; i++)
            {
                string element = input[0];
                input.RemoveAt(0);
                input.Add(element);
            }

        }

        static void Sort(string[] command, List<string> input)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);

            if (start < 0 || start >= input.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            if (count < 0 || (start + count) < 0 || (start + count - 1) >= input.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            List<string> temp = input.Skip(start).Take(count).ToList();
            temp.Sort();
            input.RemoveRange(start, count);
            input.InsertRange(start, temp);
        }

        static void Reverse(string[] command, List<string> input)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);

            if (start < 0 || start >= input.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            if (count < 0 || (start + count) < 0 || (start + count - 1) >= input.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            List<string> temp = input.Skip(start).Take(count).Reverse().ToList();
            input.RemoveRange(start, count);
            input.InsertRange(start, temp);
        }
    }
}