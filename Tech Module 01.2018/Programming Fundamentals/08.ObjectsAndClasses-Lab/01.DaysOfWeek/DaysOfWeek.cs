using System;
using System.Globalization;

namespace _01.DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime exactdate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(exactdate.DayOfWeek);
        }
    }
}
