using System;
using System.Linq;

namespace _06.Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] heistInfo = Console.ReadLine().Split(' ').ToArray();
            int totalEarnings = 0;
            int jewelsPrice = prices[0];
            int goldPrice = prices[1];

            while (heistInfo[0] + " " + heistInfo[1] != "Jail Time")
            {
                for (int i = 0; i < heistInfo[0].Length; i++)
                {
                    if (heistInfo[0][i] == '%')
                    {
                        totalEarnings += jewelsPrice;
                    }
                    else if (heistInfo[0][i] == '$')
                    {
                        totalEarnings += goldPrice;
                    }
                }

                totalEarnings -= int.Parse(heistInfo[1]);
                heistInfo = Console.ReadLine().Split(' ').ToArray();
            }

            if (totalEarnings >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalEarnings)}.");
            }
        }
    }
}
