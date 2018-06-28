using System;

namespace _02.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            try
            {
                long number = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");

            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }

        }
    }
}
