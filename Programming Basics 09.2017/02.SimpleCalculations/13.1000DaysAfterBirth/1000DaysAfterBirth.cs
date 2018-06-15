using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {           
            string birthDay = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime birthDate = DateTime.ParseExact(birthDay, format, CultureInfo.InvariantCulture);
            DateTime _1000DaysLater = birthDate.AddDays(999);
            Console.WriteLine(_1000DaysLater.ToString(format));
        }
    }
}