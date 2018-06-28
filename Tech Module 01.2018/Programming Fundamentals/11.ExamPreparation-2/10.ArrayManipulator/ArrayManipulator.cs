using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange":
                        numbers = ExchangePartsOfArray(numbers, command);
                        break;
                    case "max":
                        FindMaxOddOrEven(numbers, command);
                        break;
                    case "min":
                        FindMinOddOrEven(numbers, command);
                        break;
                    case "first":
                        GetFirst(numbers, command);
                        break;
                    case "last":
                        GetLast(numbers, command);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static void GetLast(int[] numbers, string[] command)
        {
            int count = int.Parse(command[1]);

            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> elements = new List<int>();;

            if (command[2] == "even")
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    if (numbers[i] % 2 == 0)
                    {
                        elements.Add(numbers[i]);
                        count--;
                    }
                }
            }
            else
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    if (numbers[i] % 2 != 0)
                    {
                        elements.Add(numbers[i]);
                        count--;
                    }
                }
            }

            elements.Reverse();
            Console.WriteLine("[" + string.Join(", ", elements) + "]");
        }

        static void GetFirst(int[] numbers, string[] command)
        {
            int count = int.Parse(command[1]);

            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> elements = new List<int>();

            if (command[2] == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    if (numbers[i] % 2 == 0)
                    {
                        elements.Add(numbers[i]);
                        count--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    if (numbers[i] % 2 != 0)
                    {
                        elements.Add(numbers[i]);
                        count--;
                    }
                }
            }

            Console.WriteLine("[" + string.Join(", ", elements) + "]");    
        }

        static void FindMinOddOrEven(int[] numbers, string[] command)
        {
            int index = -1;
            int min = int.MaxValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] <= min)
                    {
                        min = numbers[i];
                        index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] <= min)
                    {
                        min = numbers[i];
                        index = i;
                    }
                }
            }

            if (index > -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void FindMaxOddOrEven(int[] numbers, string[] command)
        {
            int index = -1;
            int max = int.MinValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] >= max)
                    {
                        max = numbers[i];
                        index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] >= max)
                    {
                        max = numbers[i];
                        index = i;
                    }
                }
            }
            
            if (index > -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static int[] ExchangePartsOfArray(int[] numbers, string[] command)
        {
            int index = int.Parse(command[1]);

            if (index < 0 || index >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            List<int> exchanged = new List<int>();

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchanged.Add(numbers[i]);
            }
            for (int i = 0; i <= index; i++)
            {
                exchanged.Add(numbers[i]);
            }

            numbers = exchanged.ToArray();
            return numbers;
        }
    }
}
