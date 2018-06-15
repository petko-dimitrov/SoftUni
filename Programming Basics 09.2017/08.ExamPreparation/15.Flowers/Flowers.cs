using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine().ToUpper();

            double price = 0.0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    price = chrysanthemums * 2.0 + roses * 4.1 + tulips * 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    price = chrysanthemums * 3.75 + roses * 4.5 + tulips * 4.15;
                    break;
                default:
                    break;
            }

            if (isHoliday == "Y")
            {
                price *= 1.15;
            }
            if (tulips > 7 && season == "Spring") 
            {
                price *= 0.95;
            }
            if (roses >= 10 && season == "Winter")
            {
                price *= 0.9;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                price *= 0.8;
            }
            price += 2;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
