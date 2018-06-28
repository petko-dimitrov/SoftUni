using System;
using System.Text.RegularExpressions;

namespace _03.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            string[] snowflake = new string[5];

            for (int i = 0; i < 5; i++)
            {
                snowflake[i] = Console.ReadLine();
            }

            string surfaceRegex = @"^[^A-Za-z0-9]+$";
            string mantleRegex = @"^[0-9_]+$";
            string coreRegex = @"^[^A-Za-z0-9]+[0-9_]+([A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$";

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                    case 4:
                        if (!Regex.IsMatch(snowflake[i], surfaceRegex))
                        {
                            Console.WriteLine("Invalid");
                            return;
                        }
                        break;
                    case 1:
                    case 3:
                        if (!Regex.IsMatch(snowflake[i], mantleRegex))
                        {
                            Console.WriteLine("Invalid");
                            return;
                        }
                        break;
                    case 2:
                        if (!Regex.IsMatch(snowflake[i], coreRegex))
                        {
                            Console.WriteLine("Invalid");
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }

            int coreLength = Regex.Match(snowflake[2], coreRegex).Groups[1].Length;
            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);
        }
    }
}
