using System;

namespace _13.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            ulong runners = ulong.Parse(Console.ReadLine());
            uint avgLapsPerRunner = uint.Parse(Console.ReadLine());
            uint trackLength = uint.Parse(Console.ReadLine());
            uint trackCapacity = uint.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            ulong runnersCapacity = trackCapacity * days;

            if (runners > runnersCapacity)
            {
                runners = runnersCapacity;
            }

            double totalKm = 1.0 * runners * avgLapsPerRunner * trackLength / 1000;
            double totalMoney = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
