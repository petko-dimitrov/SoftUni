using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double p1Water = p1 * h;
            double p2Water = p2 * h;
            double totalWater = p1Water + p2Water;
            if (totalWater <= v)
            {
                double percentFull = Math.Floor(totalWater / v * 100);
                double percentP1 = Math.Floor(p1Water / totalWater * 100);
                double percentP2 = Math.Floor(p2Water / totalWater * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    percentFull, percentP1, percentP2);
            }
            else
            {
                double overflow = totalWater - v;
                Console.WriteLine($"For {h} hours the pool overflows with {overflow} liters.");
            }
        }
    }
}
