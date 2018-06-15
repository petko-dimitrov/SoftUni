using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double moneyGift = 10.00;
            double totalSum = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalSum += moneyGift - 1;
                    moneyGift += 10;
                }
                else
                {
                    totalSum += toyPrice;
                }
            }

            if (totalSum >= washingMashinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", totalSum - washingMashinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMashinePrice - totalSum);
            }
        }
    }
}
