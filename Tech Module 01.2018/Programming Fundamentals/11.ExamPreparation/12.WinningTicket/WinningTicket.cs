using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\${6,10}|@{6,10}|#{6,10}|\^{6,10}";

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string firstHalf = "";
                string secondHalf = "";

                for (int j = 0; j < 10; j++)
                {
                    firstHalf += tickets[i][j];
                    secondHalf += tickets[i][j + 10];

                }

                if (Regex.IsMatch(firstHalf, pattern) && Regex.IsMatch(secondHalf, pattern))
                {
                    string firstWinPattern = Regex.Match(firstHalf, pattern).Value;
                    string secondWinPattern = Regex.Match(secondHalf, pattern).Value;

                    if (firstWinPattern[0] == secondWinPattern[0])
                    {
                        if (firstWinPattern.Length == 10 && secondWinPattern.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {firstWinPattern.Length}{firstWinPattern[0]} Jackpot!");
                        }
                        else if (firstWinPattern.Length >= secondWinPattern.Length) 
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {secondWinPattern.Length}{firstWinPattern[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {firstWinPattern.Length}{firstWinPattern[0]}");
                        }
                    }                    
                }
                else
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                }
            }
        }
    }
}
