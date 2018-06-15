using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CourierExpress
{
    class CourierExpress
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string typeOfDelivery = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double price = 0.0;
            double overprice = 0.0;

            switch (typeOfDelivery)
            {
                case "standard":
                    if (weight < 1)
                    {
                        price = distance * 0.03;
                    }
                    else if (weight <= 10)
                    {
                        price = distance * 0.05;
                    }
                    else if (weight <= 40)
                    {
                        price = distance * 0.1;
                    }
                    else if (weight <= 90)
                    {
                        price = distance * 0.15;
                    }
                    else
                    {
                        price = distance * 0.2;
                    }
                    break;
                case "express":
                    if (weight < 1)
                    {
                        overprice = 0.03 * 0.8 * weight * distance;
                        price = distance * 0.03 + overprice;
                    }
                    else if (weight <= 10)
                    {
                        overprice = 0.05 * 0.4 * weight * distance;
                        price = distance * 0.05 + overprice;
                    }
                    else if (weight <= 40)
                    {
                        overprice = 0.1 * 0.05 * weight * distance;
                        price = distance * 0.1 + overprice;
                    }
                    else if (weight <= 90)
                    {
                        overprice = 0.15 * 0.02 * weight * distance;               
                        price = distance * 0.15 + overprice;
                    }
                    else
                    {
                        overprice = 0.2 * 0.01 * weight * distance;
                        price = distance * 0.2 + overprice;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.",
                weight, price);
        }
    }
}
