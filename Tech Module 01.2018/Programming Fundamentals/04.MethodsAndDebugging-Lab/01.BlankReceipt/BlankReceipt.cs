using System;

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\r\n------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\r\nReceived by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------\r\n\u00A9 SoftUni");
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
