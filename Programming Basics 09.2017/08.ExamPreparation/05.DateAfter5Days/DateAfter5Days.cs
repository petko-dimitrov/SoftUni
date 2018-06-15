using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateAfter5Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(2017, month, day);
            date = date.AddDays(5);
            Console.WriteLine(date.ToString("d.MM"));
        }
    }
}
