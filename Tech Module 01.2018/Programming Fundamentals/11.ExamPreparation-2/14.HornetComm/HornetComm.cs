using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _14.HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
                
            string messagePattern = @"([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcastPattern = @"([^0-9]+) <-> ([A-Za-z0-9]+)$";
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string queries = Console.ReadLine();

            while (queries != "Hornet is Green")
            {
                if (Regex.IsMatch(queries, messagePattern))
                {
                    string[] messageParts = queries
                        .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    string code = messageParts[0];
                    code = ReverseString(code);
                    string message = code + " -> " + messageParts[1];
                    messages.Add(message);
                }

                else if (Regex.IsMatch(queries, broadcastPattern))
                {
                    string[] broadcastParts = queries
                        .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    string frequency = broadcastParts[1];
                    string updatesFrequency = "";

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (frequency[i] >= 'a' && frequency[i] <= 'z')
                        {
                            updatesFrequency += frequency[i].ToString().ToUpper();
                        }
                        else if (frequency[i] >= 'A' && frequency[i] <= 'Z')
                        {
                            updatesFrequency += frequency[i].ToString().ToLower();
                        }
                        else
                        {
                            updatesFrequency += frequency[i].ToString();
                        }
                    }

                    string message = updatesFrequency + " -> " + broadcastParts[0];
                    broadcasts.Add(message);
                }

                queries = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
