using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.FruitCocktails
{
    class FruitCocktails
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string size = Console.ReadLine().ToLower();
            int number = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (fruit)
            {
                case "watermelon":
                    if (size == "small")
                    {
                        price = number * 2 * 56;
                    }
                    else if (size == "big")
                    {
                        price = number * 5 * 28.7;
                    }
                    break;
                case "mango":
                    if (size == "small")
                    {
                        price = number * 2 * 36.66;
                    }
                    else if (size == "big")
                    {
                        price = number * 5 * 19.6;
                    }
                    break;
                case "pineapple":
                    if (size == "small")
                    {
                        price = number * 2 * 42.1;
                    }
                    else if (size == "big")
                    {
                        price = number * 5 * 24.8;
                    }
                    break;
                case "raspberry":
                    if (size == "small")
                    {
                        price = number * 2 * 20;
                    }
                    else if (size == "big")
                    {
                        price = number * 5 * 15.2;
                    }
                    break;
                default:
                    break;
            }
            if (price > 1000)
            {
                price -= price * 0.5;
            }
            else if (price >= 400 && price <= 1000)
            {
                price -= price * 0.15;
            }
            Console.WriteLine("{0:f2} lv.", price);
        }
    }
}
