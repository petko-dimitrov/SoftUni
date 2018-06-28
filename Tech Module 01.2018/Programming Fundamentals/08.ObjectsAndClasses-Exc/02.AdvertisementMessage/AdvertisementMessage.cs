using System;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[rand.Next(0, phrases.Length)];
                string randEvent = events[rand.Next(0, events.Length)];
                string author = authors[rand.Next(0, authors.Length)];
                string city = cities[rand.Next(0, cities.Length)];
                Console.WriteLine($"{phrase} {randEvent} {author} - {city}");
            }
        }
    }
}
