using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string typeOfGroup = Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            string sport = "";

            switch (season)
            {
                case "winter":
                    if (typeOfGroup == "boys")
                    {
                        price = nights * 9.6 * students;
                        sport = "Judo";
                    }
                    else if (typeOfGroup == "girls")
                    {
                        price = nights * 9.6 * students;
                        sport = "Gymnastics";
                    }
                    else if (typeOfGroup == "mixed")
                    {
                        price = nights * 10 * students;
                        sport = "Ski";
                    }
                    break;
                case "spring":
                    if (typeOfGroup == "boys")
                    {
                        price = nights * 7.2 * students;
                        sport = "Tennis";
                    }
                    else if (typeOfGroup == "girls")
                    {
                        price = nights * 7.2 * students;
                        sport = "Athletics";
                    }
                    else if (typeOfGroup == "mixed")
                    {
                        price = nights * 9.5 * students;
                        sport = "Cycling";
                    }
                    break;
                case "summer":
                    if (typeOfGroup == "boys")
                    {
                        price = nights * 15 * students;
                        sport = "Football";
                    }
                    else if (typeOfGroup == "girls")
                    {
                        price = nights * 15 * students;
                        sport = "Volleyball";
                    }
                    else if (typeOfGroup == "mixed")
                    {
                        price = nights * 20 * students;
                        sport = "Swimming";
                    }
                    break;
                default:
                    break;
            }
            if (students >= 50)
            {
                price -= 0.5 * price;
            }
            else if (students >= 20 && students < 50)
            {
                price -= 0.15 * price;
            }
            else if (students >= 10 && students < 20)
            {
                price -= 0.05 * price;
            }

            Console.WriteLine("{0} {1:f2} lv.", sport, price);
        }
    }
}
