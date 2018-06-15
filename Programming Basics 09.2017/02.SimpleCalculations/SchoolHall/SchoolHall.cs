using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            if (h < 3 || w < 3 || h > 100 || w > 100)
            {

                throw new System.ArgumentOutOfRangeException("h and w must be between 3 and 100!");
            }
            double height = h * 100;
            double width = w * 100 - 100;
            double workHeigth = 120;
            double workWidth = 70;
            double rows = Math.Floor(height / workHeigth);
            double desksPerRow = Math.Floor(width / workWidth);
            double workPlaces = rows * desksPerRow - 3;
            Console.WriteLine(workPlaces);
        }
    }
}