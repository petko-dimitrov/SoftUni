using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            var numbers = new List<int>();

            for (int j = 0; j <= input.Length - 1; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            bool isPositive = false;

            for (int k = 0; k <= numbers.Count - 1; k++)
            {
                int currentNum = numbers[k];

                if (currentNum >= 0 && k != numbers.Count - 1)
                {
                    result += currentNum + " ";
                    isPositive = true;
                }
                else if (currentNum >= 0 && k == numbers.Count - 1)
                {
                    result += currentNum;
                    isPositive = true;
                }
                else if (k != numbers.Count - 1)
                {
                    currentNum += numbers[k + 1];
                    k++;

                    if (currentNum >= 0 && k != numbers.Count - 1)
                    {
                        result += currentNum + " ";
                        isPositive = true;
                    }
                    else if (currentNum >= 0 && k == numbers.Count - 1)
                    {
                        result += currentNum;
                        isPositive = true;
                    }
                }
            }

            if (!isPositive)
            {
                result += "(empty)";
            }
            result += "\r\n";
        }

        Console.WriteLine(result);
    }
}