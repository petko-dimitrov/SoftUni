using System;
using System.Linq;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string subStr = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(subStr);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(subStr, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
