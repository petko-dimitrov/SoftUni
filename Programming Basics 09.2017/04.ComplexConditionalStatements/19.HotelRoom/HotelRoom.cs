using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            decimal appartmentPrice = 0.0m;
            decimal studioPrice = 0.0m;
            switch (month)
            {
                case "may":
                case "october":
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice = nights * 50m * 0.95m;
                        appartmentPrice = nights * 65m;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 50m * 0.7m;
                        appartmentPrice = nights * 65m * 0.9m;
                    }
                    else
                    {
                        studioPrice = nights * 50m;
                        appartmentPrice = nights * 65m;
                    }
                    break;
                case "june":
                case "september":                    
                    if (nights > 14)
                    {
                        studioPrice = nights * 75.20m * 0.8m;
                        appartmentPrice = nights * 68.70m * 0.9m;
                    }
                    else
                    {
                        studioPrice = nights * 75.20m;
                        appartmentPrice = nights * 68.70m;
                    }
                    break;
                case "july":
                case "august":
                    if (nights > 14)
                    {
                        studioPrice = nights * 76m;
                        appartmentPrice = nights * 77m * 0.9m;
                    }
                    else
                    {
                        studioPrice = nights * 76m;
                        appartmentPrice = nights * 77m;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Apartment: {0:F2} lv.", appartmentPrice);
            Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
        }
    }
}
