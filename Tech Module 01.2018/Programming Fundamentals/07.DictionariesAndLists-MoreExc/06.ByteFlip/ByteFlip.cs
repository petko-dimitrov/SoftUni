using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ByteFlip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            string[] bytesInHex = Console.ReadLine().Split();
            List<string> bytes = new List<string>();

            for (int i = 0; i < bytesInHex.Length; i++)
            {
                if (bytesInHex[i].Length == 2)
                {
                    bytes.Add(bytesInHex[i]);
                }
            }

            for (int i = 0; i < bytes.Count; i++)
            {
                string reversed = "";
                for (int j = bytes[i].Length -1; j >= 0; j--)
                {
                    reversed += bytes[i][j];
                }
                bytes[i] = reversed;
            }

            bytes.Reverse();

            foreach (var hexByte in bytes)
            {
                int character = Convert.ToInt32(hexByte, 16);
                Console.Write((char)character);
            }
        }
    }
}
