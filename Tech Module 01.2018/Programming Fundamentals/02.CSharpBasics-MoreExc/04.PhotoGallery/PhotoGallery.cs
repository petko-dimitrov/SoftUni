using System;

namespace _04.PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation = "";

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (height > width)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }


            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg\r\n" +
                $"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size < 1000000)
            {
                Console.WriteLine($"Size: {size / 1000.0}KB");
            }
            else
            {
                Console.WriteLine($"Size: {size / 1000000.0}MB");
            }
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
