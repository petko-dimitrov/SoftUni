using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[]
           {
                new DateTime (2015, 1, 1),
                new DateTime (2015, 3, 3),
                new DateTime (2015, 5, 1),
                new DateTime (2015, 5, 6),
                new DateTime (2015, 5, 24),
                new DateTime (2015, 9, 6),
                new DateTime (2015, 9, 22),
                new DateTime (2015, 11, 1),
                new DateTime (2015, 12, 24),
                new DateTime (2015, 12, 25),
                new DateTime (2015, 12, 26)
           };

            int workDaysCount = 0;

            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                bool isHoliday = false;

                for (int j = 0; j < holidays.Length; j++)
                {
                    DateTime tempHolidayCheck = holidays[j];

                    if (i.Day == tempHolidayCheck.Day && i.Month == tempHolidayCheck.Month)
                    {
                        isHoliday = true;
                    }
                }

                if (!isHoliday)
                {
                    workDaysCount++;
                }
            }

            Console.WriteLine(workDaysCount);
        }
    }
}
