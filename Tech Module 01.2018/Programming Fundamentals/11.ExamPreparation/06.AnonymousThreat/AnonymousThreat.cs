using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commandInfo = input.Split();
                string command = commandInfo[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);
                    MergeData(data, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandInfo[1]);
                    int partitions = int.Parse(commandInfo[2]);
                    DivideData(data, index, partitions);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }

        static void DivideData(List<string> data, int index, int partitions)
        {
            if (partitions == 0 || partitions == 1)
            {
                return;
            }
            List<string> dividedData = new List<string>();
            string wordToDivide = data[index];
            int substrLength = wordToDivide.Length / partitions;

            while (wordToDivide.Length >= substrLength)
            {
                string currentSubstr = wordToDivide.Substring(0, substrLength);
                dividedData.Add(currentSubstr);
                wordToDivide = wordToDivide.Substring(substrLength);
            }

            if (wordToDivide.Length > 0)
            {
                dividedData[dividedData.Count - 1] += wordToDivide;
            }

            data.InsertRange(index + 1, dividedData);
            data.RemoveAt(index);
        }

        static void MergeData(List<string> data, int startIndex, int endIndex)
        {
            string mergedString = "";
            if (startIndex >= data.Count || endIndex <= 0)
            {
                return;
            }
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= data.Count)
            {
                endIndex = data.Count - 1;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedString += data[i];
            }

            data.Insert(endIndex + 1, mergedString);
            data.RemoveRange(startIndex, endIndex - startIndex + 1);
        }
    }
}
