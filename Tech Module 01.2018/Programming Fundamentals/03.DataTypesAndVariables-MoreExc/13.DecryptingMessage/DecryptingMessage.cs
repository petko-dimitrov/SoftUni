using System;

namespace _13.DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());               
                message += (char)(character + key);
            }
            Console.WriteLine(message);
        }
    }
}
