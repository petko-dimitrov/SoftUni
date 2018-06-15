using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.MobileOperator
{
    class MobileOperator
    {
        static void Main(string[] args)
        {
            string limit = Console.ReadLine().ToLower();
            string type = Console.ReadLine().ToLower();
            string internet = Console.ReadLine().ToLower();
            int months = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (limit == "one")
            {
                switch (type)
                {
                    case "small":
                        if (internet == "yes")
                        {
                            price = months * (9.98 + 5.5);
                        }
                        else
                        {
                            price = months * 9.98;
                        }
                        break;
                    case "middle":
                        if (internet == "yes")
                        {
                            price = months * (18.99 + 4.35);
                        }
                        else
                        {
                            price = months * 18.99;
                        }
                        break;
                    case "large":
                        if (internet == "yes")
                        {
                            price = months * (25.98 + 4.35);
                        }
                        else
                        {
                            price = months * 25.98;
                        }
                        break;
                    case "extralarge":
                        if (internet == "yes")
                        {
                            price = months * (35.99 + 3.85);
                        }
                        else
                        {
                            price = months * 35.99;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (limit == "two")
            {
                switch (type)
                {
                    case "small":
                        if (internet == "yes")
                        {
                            price = months * (8.58 + 5.5);
                        }
                        else
                        {
                            price = months * 8.58;
                        }
                        break;
                    case "middle":
                        if (internet == "yes")
                        {
                            price = months * (17.09 + 4.35);
                        }
                        else
                        {
                            price = months * 17.09;
                        }
                        break;
                    case "large":
                        if (internet == "yes")
                        {
                            price = months * (23.59 + 4.35);
                        }
                        else
                        {
                            price = months * 23.59;
                        }
                        break;
                    case "extralarge":
                        if (internet == "yes")
                        {
                            price = months * (31.79 + 3.85);
                        }
                        else
                        {
                            price = months * 31.79;
                        }
                        break;
                    default:
                        break;
                }
                price = 0.9625 * price;
            }

            Console.WriteLine("{0:f2} lv.", price);
        }
    }
}
