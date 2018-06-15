using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            string fromMetric = Console.ReadLine().ToLower();
            string toMetric = Console.ReadLine().ToLower();
            switch (fromMetric)
            {
                case "mm":
                    size /= 1000;
                    break;
                case "cm":
                    size /= 100;
                    break;
                case "mi":
                    size /= 0.000621371192;
                    break;
                case "in":
                    size /= 39.3700787;
                    break;
                case "km":
                    size /= 0.001;
                    break;
                case "ft":
                    size /= 3.2808399;
                    break;
                case "yd":
                    size /= 1.0936133;
                    break;
                default:
                    break;
            }
            switch (toMetric)
            {
                case "mm":
                    size *= 1000;
                    break;
                case "cm":
                    size *= 100;
                    break;
                case "mi":
                    size *= 0.000621371192;
                    break;
                case "in":
                    size *= 39.3700787;
                    break;
                case "km":
                    size *= 0.001;
                    break;
                case "ft":
                    size *= 3.2808399;
                    break;
                case "yd":
                    size *= 1.0936133;
                    break;
                default:
                    break;
            }
            Console.WriteLine(size);
        } 
    }
}
