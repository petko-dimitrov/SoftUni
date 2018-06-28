using System;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            byte temporary = 0;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            temporary = a;
            a = b;
            b = temporary;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
