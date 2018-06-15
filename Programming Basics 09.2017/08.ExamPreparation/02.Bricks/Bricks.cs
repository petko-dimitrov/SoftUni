using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cartCapacity = int.Parse(Console.ReadLine());

            double cources = Math.Ceiling((double)bricks / (workers * cartCapacity));
            Console.WriteLine(cources);
        }
    }
}
