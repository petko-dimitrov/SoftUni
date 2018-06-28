using System;

namespace _17.PrintPartOfASCCITable
{
    class PrintPartOfASCCITable
    {
        static void Main(string[] args)
        {
            int startCharIndex = int.Parse(Console.ReadLine());
            int endCharIndex = int.Parse(Console.ReadLine());

            for (char i = (char)startCharIndex; i <= endCharIndex; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
