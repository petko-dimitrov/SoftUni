using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int exam = 60 * examHour + examMinutes;
            int arrival = 60 * arriveHour + arriveMinutes;
            int difference = arrival - exam;
            if (exam < arrival)
            {
                Console.WriteLine("Late");
                if (difference < 60)
                {
                    Console.WriteLine("{0} minutes after the start", difference);
                }
                else
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
                    }
                }
            }
            else if (exam >= arrival)
            {
                if ((exam - arrival) <= 30)
                {
                    Console.WriteLine("On Time");
                }
                else
                {
                    Console.WriteLine("Early");
                }
                difference = Math.Abs(difference);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
                    }
                }
            }
        }
    }
}
