using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WireNet
{
    class WireNet
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double pricePerMeter = double.Parse(Console.ReadLine());
            double weightPerSqrMeter = double.Parse(Console.ReadLine());

            int wireLength = 2 * length + 2 * width;
            double wirePrice = wireLength * pricePerMeter;
            double wireArea = wireLength * height;
            double wireWeight = wireArea * weightPerSqrMeter;

            Console.WriteLine(wireLength);
            Console.WriteLine("{0:f2}", wirePrice);
            Console.WriteLine("{0:f3}", wireWeight);
        }
    }
}
