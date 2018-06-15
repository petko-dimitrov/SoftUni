using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;
            double electricity = 0.0;
            double others = 0.0;
            double othersPerMonth = 0.0;
            double average = 0.0;

            for (int i = 0; i < months; i++)
            {
                double electricityPerMonth = double.Parse(Console.ReadLine());
                electricity += electricityPerMonth;
                othersPerMonth = (electricityPerMonth + water + internet) * 1.2;
                others += othersPerMonth;
                average += water + internet + electricityPerMonth + othersPerMonth;
            }

            Console.WriteLine("Electricity: {0:f2} lv", electricity);
            Console.WriteLine("Water: {0:f2} lv", water * months);
            Console.WriteLine("Internet: {0:f2} lv", internet * months);
            Console.WriteLine("Other: {0:f2} lv", others);
            Console.WriteLine("Average: {0:f2} lv", average / months);
        }
    }
}
