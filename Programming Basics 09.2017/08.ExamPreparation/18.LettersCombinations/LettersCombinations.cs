using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char letterToMiss = char.Parse(Console.ReadLine());
            int count = 0;

            for (int char1 = startLetter; char1 <= endLetter; char1++)
            {
                for (int char2 = startLetter; char2 <= endLetter; char2++)
                {
                    for (int char3 = startLetter; char3 <= endLetter; char3++)
                    {
                        if (char1 != letterToMiss && char2 != letterToMiss && char3 != letterToMiss)
                        {
                            Console.Write($"{(char)char1}{(char)char2}{(char)char3} ");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
