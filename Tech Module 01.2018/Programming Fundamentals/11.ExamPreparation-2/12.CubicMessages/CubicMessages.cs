using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _12.CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            string pattern = @"^([0-9]+)([A-Za-z]+)([^A-Za-z]*)$";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Over!")
                {
                    break;
                }

                int messageLength = int.Parse(Console.ReadLine());
                string message = "";
                string verificationCode = "";

                if (Regex.IsMatch(input, pattern))
                {
                    message = Regex.Match(input, pattern).Groups["2"].Value;

                    if (message.Length != messageLength)
                    {
                        continue;
                    }

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (IsDigit(input[i]))
                        {
                            int index = int.Parse(input[i].ToString());

                            if (index >= 0 && index < message.Length)
                            {
                                verificationCode += message[index];
                            }
                            else
                            {
                                verificationCode += " ";
                            }
                        }
                    }

                    Console.WriteLine($"{message} == {verificationCode}");
                }               
            }
        }

        static bool IsDigit(char symbol)
        {
            bool isDigit = false;

            if (symbol >= 48 && symbol <= 57)
            {
                isDigit = true;
            }

            return isDigit;
        }
    }
}
