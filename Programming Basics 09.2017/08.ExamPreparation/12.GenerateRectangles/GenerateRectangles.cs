using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int area = 0;
            int count = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            area = Math.Abs(right - left) * Math.Abs((bottom - top));
                            if (area >= m)
                            {
                                count++;
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
