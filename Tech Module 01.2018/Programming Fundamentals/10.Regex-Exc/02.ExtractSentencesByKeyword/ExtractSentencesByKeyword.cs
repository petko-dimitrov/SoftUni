using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine().ToLower();
            string[] sentences = Console.ReadLine()
                .Split(new char[] {'.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
            string regex = $@"\b{keyWord}\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, regex))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
