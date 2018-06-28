using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            char[] symbols = File.ReadAllText("input.txt").ToCharArray();
            Dictionary<char, int> symbolCounts = new Dictionary<char, int>();

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == ' ')
                {
                    continue;
                }
                if (!symbolCounts.ContainsKey(symbols[i]))
                {
                    symbolCounts.Add(symbols[i], 1);
                }
                else
                {
                    symbolCounts[symbols[i]]++;
                }
            }

            foreach (var symbol in symbolCounts.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", $"{symbol.Key} -> {symbol.Value}\r\n");
            }
        }
    }
}
