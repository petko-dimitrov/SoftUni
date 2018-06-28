using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                if (!emails.ContainsKey(name))
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }

            foreach (var mail in emails)
            {
                if (!mail.Value.EndsWith("us") && !mail.Value.EndsWith("uk"))
                {
                    Console.WriteLine($"{mail.Key} -> {mail.Value}");
                }
            }
        }
    }
}
