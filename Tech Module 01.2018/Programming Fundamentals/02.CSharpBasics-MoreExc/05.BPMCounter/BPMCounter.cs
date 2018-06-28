using System;

namespace _05.BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0, 1);
            double beatsPerSeconds = beatsPerMinute / 60.0;
            double seconds = Math.Floor(beats / beatsPerSeconds);
            int minutes = 0;

            minutes = (int)seconds / 60;
            seconds = seconds % 60;
           
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
