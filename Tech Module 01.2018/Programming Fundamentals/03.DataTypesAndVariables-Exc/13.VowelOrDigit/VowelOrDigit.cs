using System;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            try
            {
                int inputAsDigit = Convert.ToInt32(input);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
