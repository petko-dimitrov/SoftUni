using System;

namespace _04.VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string numberInHex = Console.ReadLine();
            int numberInDecimal = Convert.ToInt32(numberInHex, 16);
            Console.WriteLine(numberInDecimal);

        }
    }
}
