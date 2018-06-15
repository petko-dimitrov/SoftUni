using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int firstCompetitor = int.Parse(Console.ReadLine());
            int secondCompetitor = int.Parse(Console.ReadLine());
            int thirdCompetitor = int.Parse(Console.ReadLine());
            int seconds = firstCompetitor + secondCompetitor + thirdCompetitor;
            int minutes = 0;
            if (seconds > 59)
            {
                minutes++;
                seconds -= 60;
            }
            if (seconds > 59)
            {
                minutes++;
                seconds -= 60;
            }
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
