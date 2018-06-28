using System;

namespace _13.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double totalDistance = wingFlaps / 1000 * distancePer1000Flaps;
            double time = wingFlaps / 100 + wingFlaps / endurance * 5;

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
