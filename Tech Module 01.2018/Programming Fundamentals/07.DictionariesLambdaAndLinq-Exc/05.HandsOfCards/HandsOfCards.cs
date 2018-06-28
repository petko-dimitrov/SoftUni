using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(':')
                .ToArray();
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();
            List<string> cardsInput = new List<string>();

            while (input[0] != "JOKER")
            {
                cardsInput = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!cards.ContainsKey(input[0]))
                {
                    cards.Add(input[0], cardsInput);
                }
                else
                {
                    cards[input[0]].AddRange(cardsInput);                   
                }
                cards[input[0]] = cards[input[0]].Distinct().ToList();

                input = Console.ReadLine()
                .Split(':')
                .ToArray();
            }

            int sum = 0;
            int multiplier = 0;
            int value = 0;

            foreach (var pair in cards)
            {
                foreach (var card in pair.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                        default:
                            break;
                    }
                    string cardValue = card.Remove(card.Length - 1, 1);
                    switch (cardValue)
                    {
                        case "10":
                            value = 10;
                            break;
                        case "J":
                            value = 11;
                            break;
                        case "Q":
                            value = 12;
                            break;
                        case "K":
                            value = 13;
                            break;
                        case "A":
                            value = 14;
                            break;
                        default:
                            value = int.Parse(cardValue);                            
                            break;
                    }
                    sum += multiplier * value;
                }
                Console.WriteLine($"{pair.Key}: {sum}");
                sum = 0;
            }
        }
    }
}
