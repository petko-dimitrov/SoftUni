using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesTaken = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine()); 
            int filterFactor = int.Parse(Console.ReadLine()); 
            int uploadTime = int.Parse(Console.ReadLine());

            long totalFilterTime = Convert.ToInt64(filterTime) * picturesTaken;
            double picturesKept = Math.Ceiling(1.0 * picturesTaken * filterFactor / 100);
            long totalUploadTime = Convert.ToInt64(picturesKept) * uploadTime;
            long totalSeconds = totalUploadTime + totalFilterTime;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string format = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(format);
        }
    }
}
