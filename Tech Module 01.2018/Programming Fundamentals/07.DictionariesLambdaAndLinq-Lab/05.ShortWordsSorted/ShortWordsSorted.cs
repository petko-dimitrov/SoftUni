using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower()
                .Split(new char[] {'.', ',', ':', ';', '(', ')','[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            words = words.Where(w => w.Length < 5).Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
