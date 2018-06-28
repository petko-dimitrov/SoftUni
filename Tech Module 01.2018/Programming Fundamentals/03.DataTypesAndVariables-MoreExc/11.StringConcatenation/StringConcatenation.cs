using System;

namespace _11.StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string concatenatedString = "";

            for (int i = 1; i <= numberOfLines; i++)
            {
                string word = Console.ReadLine();
                if (evenOrOdd == "even" && i % 2 == 0)
                {
                    concatenatedString += word + delimiter;
                }
                else if (evenOrOdd == "odd" && i % 2 != 0)
                {
                    concatenatedString += word + delimiter;
                }
            }

            concatenatedString = concatenatedString.Remove(concatenatedString.Length - 1);
            Console.WriteLine(concatenatedString);
        }
    }
}
