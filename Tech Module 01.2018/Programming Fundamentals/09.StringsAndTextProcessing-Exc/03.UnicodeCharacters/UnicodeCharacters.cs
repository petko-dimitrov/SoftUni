using System;
using System.Text;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] symbols = text.ToCharArray();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < symbols.Length; i++)
            {
                builder.Append("\\u");
                builder.Append(String.Format("{0:x4}", (int)symbols[i]));
            }

            Console.WriteLine(builder);
        }
    }
}
