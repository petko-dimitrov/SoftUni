using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double distance = firstTime / 60.0 * speed;
            double newSpeed = speed * 1.1;
            distance += secondTime / 60.0 * newSpeed;
            newSpeed = newSpeed * 0.95;
            distance += thirdTime / 60.0 * newSpeed;

            Console.WriteLine("{0:f2}", distance);

        }
    }
}
