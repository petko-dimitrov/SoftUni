using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int playTime = restDays * 127 + workDays * 63;
            int difference = 30000 - playTime;
            if (difference < 0)
            {
                difference = Math.Abs(difference);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", difference / 60, difference % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", difference / 60, difference % 60);
            }
        }
    }
}
