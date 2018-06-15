using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEarnings
{
    class DailyEarnings
    {
        static void Main(string[] args)
        {
            int workdays = int.Parse(Console.ReadLine());
            double dollarsPerDay = double.Parse(Console.ReadLine());
            double dollarToLev = double.Parse(Console.ReadLine());
            double salary = workdays * dollarsPerDay * dollarToLev;
            double yearlySalary = salary * 12 + salary * 2.5;
            yearlySalary -= yearlySalary * 25 / 100; 
            double avgPerDay = yearlySalary / 365;
            Console.WriteLine(Math.Round(avgPerDay, 2));
        }
    }
}
