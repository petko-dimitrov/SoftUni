using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _15.NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            SortedDictionary<string, List<decimal>> demonStats = new SortedDictionary<string, List<decimal>>();
            string healthPattern = @"[^0-9\+\-\*\/\.]";
            string damagePattern = @"\-?[0-9]+\.?[0-9]*";

            for (int i = 0; i < demons.Length; i++)
            {
                decimal health = 0;
                List<decimal> currentDemonHealth = new List<decimal>();

                for (int j = 0; j < demons[i].Length; j++)
                {
                    if (Regex.IsMatch(demons[i][j].ToString(), healthPattern))
                    {
                        health += demons[i][j];
                    }
                }
                currentDemonHealth.Add(health);
                demonStats.Add(demons[i], currentDemonHealth);
            }

            foreach (var demon in demons)
            {
                decimal damage = 0;
                var numbers = Regex.Matches(demon, damagePattern);

                foreach (Match number in numbers)
                {
                    damage += decimal.Parse(number.Value);
                }

                for (int i = 0; i < demon.Length; i++)
                {
                    if (demon[i] == '*')
                    {
                        damage *= 2m;
                    }
                    else if (demon[i] == '/')
                    {
                        damage /= 2m;
                    }
                }

                demonStats[demon].Add(damage);
            }

            foreach (var demon in demonStats)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
