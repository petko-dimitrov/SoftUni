using System;
using System.Globalization;
using System.Numerics;

namespace _09.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            string[] leaveTime = Console.ReadLine().Split(':');
            BigInteger hours = BigInteger.Parse(leaveTime[0]);
            BigInteger minutes = BigInteger.Parse(leaveTime[1]);
            BigInteger seconds = BigInteger.Parse(leaveTime[2]);
            ulong numberOfSteps = ulong.Parse(Console.ReadLine());
            ulong secondsPerStep = ulong.Parse(Console.ReadLine());

            BigInteger secondsNeeded = numberOfSteps * secondsPerStep;
            hours += secondsNeeded / 3600;
            secondsNeeded = secondsNeeded % 3600;
            minutes += secondsNeeded / 60;
            secondsNeeded = secondsNeeded % 60;
            seconds += secondsNeeded;

            if (seconds > 59)
            {
                minutes++;
                seconds -= 60;
            }
            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = hours % 24;
            }

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
