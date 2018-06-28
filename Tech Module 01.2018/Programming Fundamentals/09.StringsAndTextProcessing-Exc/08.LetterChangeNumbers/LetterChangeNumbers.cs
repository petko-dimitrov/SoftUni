using System;
using System.Linq;
using System.Text;

namespace _08.LetterChangeNumbers
{
    class LetterChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal result = 0;

            foreach (var sequence in input)
            {
                long firstLetter = sequence[0];
                long secondLetter = sequence[sequence.Length - 1];
                decimal number = GetNumber(sequence);
                decimal currentResult = 0;
                

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    currentResult = number / (firstLetter - 64); 
                }
                else
                {
                    currentResult = number * (firstLetter - 96);
                }

                if (secondLetter >= 65 && secondLetter <= 90)
                {
                    currentResult -= (secondLetter - 64);
                }
                else
                {
                    currentResult += (secondLetter - 96);
                }

                result += currentResult;
            }

            Console.WriteLine($"{result:f2}");
        }

        static decimal GetNumber(string sequence)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= sequence.Length - 2; i++)
            {
                sb.Append(sequence[i]);
            }

            decimal number = decimal.Parse(sb.ToString());
            return number;
        }
    }
}
