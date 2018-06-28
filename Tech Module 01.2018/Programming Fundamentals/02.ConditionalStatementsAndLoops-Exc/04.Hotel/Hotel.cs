using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            decimal studioPrice = 0m;
            decimal doublePrice = 0m;
            decimal suitePrice = 0m;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = nights * 50;
                    doublePrice = nights * 65;
                    suitePrice = nights * 75;
                    if (nights > 7 && month == "October")
                    {
                        studioPrice -= 50;
                    }
                    if (nights > 7)
                    {
                        studioPrice *= 0.95m;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = nights * 60;
                    doublePrice = nights * 72;
                    suitePrice = nights * 82;
                    if (nights > 7 && month == "September")
                    {
                        studioPrice -= 60;
                    }
                    if (nights > 14)
                    {
                        doublePrice *= 0.9m;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = nights * 68;
                    doublePrice = nights * 77;
                    suitePrice = nights * 89;
                    if (nights > 14)
                    {
                        suitePrice *= 0.85m;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
