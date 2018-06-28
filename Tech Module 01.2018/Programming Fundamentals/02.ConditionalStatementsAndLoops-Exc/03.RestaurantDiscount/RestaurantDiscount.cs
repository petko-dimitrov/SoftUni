using System;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            decimal price = 0m;
            decimal pricePerPerson = 0m;

            if (groupSize <= 50)
            {
                switch (package)
                {
                    case "Normal":
                        price = (2500 + 500) * 0.95m;
                        break;
                    case "Gold":
                        price = (2500 + 750) * 0.9m;
                        break;
                    case "Platinum":
                        price = (2500 + 1000) * 0.85m;
                        break;
                    default:
                        break;
                }
                pricePerPerson = price / groupSize;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize <= 100)
            {
                switch (package)
                {
                    case "Normal":
                        price = (5000 + 500) * 0.95m;
                        break;
                    case "Gold":
                        price = (5000 + 750) * 0.9m;
                        break;
                    case "Platinum":
                        price = (5000 + 1000) * 0.85m;
                        break;
                    default:
                        break;
                }
                pricePerPerson = price / groupSize;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize <= 120)
            {
                switch (package)
                {
                    case "Normal":
                        price = (7500 + 500) * 0.95m;
                        break;
                    case "Gold":
                        price = (7500 + 750) * 0.9m;
                        break;
                    case "Platinum":
                        price = (7500 + 1000) * 0.85m;
                        break;
                    default:
                        break;
                }
                pricePerPerson = price / groupSize;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
