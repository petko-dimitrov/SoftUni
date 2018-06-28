using System;
using System.IO;
using System.Linq;

namespace _04.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int[] numbers = lines[i].Split().Select(int.Parse).ToArray();

                int bestLength = 1;
                int bestNumber = numbers[0];
                int length = 1;

                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[j - 1])
                    {
                        length++;
                    }
                    else
                    {
                        if (length > bestLength)
                        {
                            bestLength = length;
                            bestNumber = numbers[j - 1];
                        }

                        length = 1;
                    }
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestNumber = numbers[numbers.Length - 1];
                }

                string result = "";

                for (int k = 0; k < bestLength; k++)
                {
                    result += $"{bestNumber} ";
                }

                File.AppendAllText("output.txt", result.Trim() + Environment.NewLine);
            }
        }
    }
}
