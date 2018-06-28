using System;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber > 0 && dayNumber < 8)
            {
                Console.WriteLine(daysOfWeek[dayNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
