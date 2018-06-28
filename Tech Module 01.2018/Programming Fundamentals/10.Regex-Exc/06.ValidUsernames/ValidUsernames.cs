using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '(', ')', '\\', '/'}, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";

            List<string> validUsernames = new List<string>();

            foreach (var username in input)
            {
                if (Regex.IsMatch(username, pattern))
                {
                    validUsernames.Add(username);
                }
            }

            int maxSum = 0;
            int index = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int sum = validUsernames[i].Length + validUsernames[i+1].Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            }

            Console.WriteLine(validUsernames[index]);
            Console.WriteLine(validUsernames[index + 1]);
        }
    }
}
