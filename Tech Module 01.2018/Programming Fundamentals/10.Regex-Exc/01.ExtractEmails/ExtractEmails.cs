using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string regex = @"(?<=\s|^)[A-Za-z\d]+[\.\-_]?[\w\d]+@[\w\d\-]+\.[\w\d\-\.]+\b";
            string emailsToCheck = Console.ReadLine();

            var matches = Regex.Matches(emailsToCheck, regex);

            foreach (Match email in matches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
