using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();            
            double quantity = double.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.5); 
                }
                else if (product == "water")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);                   
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.6);                   
                }
            }
            if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.3);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.5);
                }
            }
            if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.1);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }           
        }
    }
}
