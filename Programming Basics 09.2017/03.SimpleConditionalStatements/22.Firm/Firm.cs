using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double workdays = daysAvailable * 0.9;
            double workhours = workdays * 8;
            double overtime = workers * daysAvailable * 2;
            double hoursAvailable = Math.Floor(workhours + overtime);
            if (hoursNeeded <= hoursAvailable)
            {
                double hoursLeft = hoursAvailable - hoursNeeded;
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }
            else
            {
                double hoursMoreNeeded = hoursNeeded - hoursAvailable;
                Console.WriteLine("Not enough time!{0} hours needed.", hoursMoreNeeded);
            }
        }
    }
}
