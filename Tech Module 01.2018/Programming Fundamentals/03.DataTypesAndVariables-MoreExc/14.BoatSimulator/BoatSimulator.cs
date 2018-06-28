using System;

namespace _14.BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int firstBoatTiles = 0;
            int secondBoatTiles = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }              
                else if (i % 2 != 0)
                {
                    firstBoatTiles += input.Length;
                }
                else
                {
                    secondBoatTiles += input.Length;
                }
                if (firstBoatTiles >= 50)
                {
                    Console.WriteLine(firstBoat);
                    break;
                }
                else if (secondBoatTiles >= 50)
                {
                    Console.WriteLine(secondBoat);
                    break;
                }
            }
            if (firstBoatTiles < 50 && secondBoatTiles < 50)
            {
                if (firstBoatTiles > secondBoatTiles)
                {
                    Console.WriteLine(firstBoat);
                }
                else
                {
                    Console.WriteLine(secondBoat);
                }
            }
        }
    }
}
