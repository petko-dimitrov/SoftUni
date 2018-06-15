using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());
            int ground = N * N;
            int bench = M * O;
            int area = ground - bench;
            double tileArea = W * L;
            double tiles = Math.Round(area / tileArea, 2);
            double time = Math.Round(tiles * 0.2, 2);
            Console.WriteLine(tiles);
            Console.WriteLine(time);
        }
    }
}
