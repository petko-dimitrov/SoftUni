using System;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            object concatenatedStrings = first + " " + second;
            string third = concatenatedStrings.ToString();
            Console.WriteLine(third);
        }
    }
}
