using System;
using System.Collections.Generic;
using System.IO;

namespace _05.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            Dictionary<string, string> emails = new Dictionary<string, string>();

            for (int i = 0; i < lines.Length - 1; i += 2)
            {
                if (!lines[i + 1].EndsWith("us") && !lines[i + 1].EndsWith("uk"))
                {
                    emails.Add(lines[i], lines[i + 1]);
                }
            }

            foreach (var email in emails)
            {
                File.AppendAllText("output.txt", $"{email.Key} -> {email.Value}\r\n");
            }
        }
    }
}
