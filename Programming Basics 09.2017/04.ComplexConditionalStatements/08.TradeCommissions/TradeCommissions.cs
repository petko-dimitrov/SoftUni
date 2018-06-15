using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeCommissions
{
    class TradeCommissions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            if (city == "sofia")
            {                
                if (sales >= 0 && sales <=500)
                {
                    commission = 0.05 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08 * sales;
                }
                else if (sales > 10000)
                {
                    commission = 0.12 * sales;
                }
                else
                {
                    Console.WriteLine("error");
                }
                if (commission > 0)
                {
                    Console.WriteLine(Math.Round(commission, 2));
                }
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.1 * sales;
                }
                else if (sales > 10000)
                {
                    commission = 0.13 * sales;
                }
                else
                {
                    Console.WriteLine("error");
                }
                if (commission > 0)
                {
                    Console.WriteLine(Math.Round(commission, 2));
                }                
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055 * sales;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08 * sales;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12 * sales;
                }
                else if (sales > 10000)
                {
                    commission = 0.145 * sales;
                }
                else
                {
                    Console.WriteLine("error");
                }
                if (commission > 0)
                {
                    Console.WriteLine(Math.Round(commission, 2));
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}