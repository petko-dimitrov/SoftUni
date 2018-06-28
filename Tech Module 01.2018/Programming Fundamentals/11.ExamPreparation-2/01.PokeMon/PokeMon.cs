using System;

namespace _01.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());
            int count = 0;
            decimal halfPower = pokePower * 0.5m;

            while (true)
            {
                if (pokePower == halfPower && exhaustFactor != 0)
                {
                    pokePower = pokePower / exhaustFactor;
                }

                if (pokePower >= distance)
                {
                    pokePower -= distance;
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);

        }
    }
}
