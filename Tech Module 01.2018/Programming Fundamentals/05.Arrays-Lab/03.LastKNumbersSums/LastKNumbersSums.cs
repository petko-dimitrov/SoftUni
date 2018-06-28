using System;

namespace _03.LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            long[] numbers = new long[length];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                long sum = 0;
                int counter = 0;
                for (int j = i; j >= 0; j--)
                {
                    sum += numbers[j];
                    counter++;

                    if (counter > count)
                    {
                        break;
                    }
                }
                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
