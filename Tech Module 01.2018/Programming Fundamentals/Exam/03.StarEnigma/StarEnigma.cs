using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string decryptionKeyPattern = @"[sStTaArR]";
            string messagePattern = @"(@[A-Za-z]+)[^@\-!\:>]*(\:[0-9]+)[^@\-!\:>]*(![AD]!)[^@\-!\:>]*(\-\>[0-9]+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();
                int decryptionKeyCount = 0;
                string decryptedMessage = "";

                for (int j = 0; j < message.Length; j++)
                {
                    if (Regex.IsMatch(message[j].ToString(), decryptionKeyPattern))
                    {
                        decryptionKeyCount++;
                    }
                }

                for (int k = 0; k < message.Length; k++)
                {
                    decryptedMessage += (char)(message[k] - decryptionKeyCount);
                }

                if (Regex.IsMatch(decryptedMessage, messagePattern))
                {
                    string planetName = Regex.Match(decryptedMessage, messagePattern).Groups[1].Value;
                    string attackType = Regex.Match(decryptedMessage, messagePattern).Groups[3].Value;
                    planetName = planetName.TrimStart('@');
                    attackType = attackType.Trim('!');

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                } 
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
