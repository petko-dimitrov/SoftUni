using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            double necessarySum = 0.0;
            int age = 18;

            for (int i = 1800; i <= endYear; i++)
            {
                if (i % 2 == 0)
                {
                    necessarySum += 12000;
                }
                else
                {
                    necessarySum += 12000 + 50 * age;
                }
                age++;
            }

            if (inheritance >= necessarySum)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",
                    inheritance - necessarySum);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", necessarySum - inheritance);
            }
        }
    }
}
