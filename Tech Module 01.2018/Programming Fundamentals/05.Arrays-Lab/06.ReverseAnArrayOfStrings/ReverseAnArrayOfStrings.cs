using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            string[] reversed = arr.Reverse().ToArray();
            
            Console.WriteLine(String.Join(" ", reversed));       
        }
    }
}
