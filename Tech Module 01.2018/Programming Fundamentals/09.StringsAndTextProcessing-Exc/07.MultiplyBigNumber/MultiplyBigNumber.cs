using System;
using System.Linq;
using System.Text;

namespace _07.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int remainder = 0;
            StringBuilder builder = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(number[i].ToString());
                
                int currentProduct = currentDigit * multiplier + remainder;
                builder.Append(currentProduct % 10);

                if (currentProduct > 9)
                {
                    remainder = currentProduct / 10;                    
                }
                else
                {
                    remainder = 0;
                }

            }

            if (remainder > 0)
            {
                builder.Append(remainder);
            }

            Console.WriteLine(builder.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());

        }
    }
}
