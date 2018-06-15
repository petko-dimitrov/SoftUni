using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")     
                {
                    Console.WriteLine(quantity * 2.5);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(quantity * 0.85);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(quantity * 2.7);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(quantity * 5.5);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(quantity * 2.7);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(quantity * 1.25);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(quantity * 0.9);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(quantity * 1.6);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(quantity * 3.0);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(quantity * 5.6);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(quantity * 4.2);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
