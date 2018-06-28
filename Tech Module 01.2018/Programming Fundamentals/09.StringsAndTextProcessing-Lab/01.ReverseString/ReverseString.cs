using System;
using System.Linq;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            char[] reversedInput = input.Reverse().ToArray();
            Console.WriteLine(string.Join("", reversedInput));
        }
    }
}
