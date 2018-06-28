using System;

namespace _08.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string dataTypeToCompare = Console.ReadLine().ToLower();

            switch (dataTypeToCompare)
            {
                case "int":
                    int firstInteger= int.Parse(Console.ReadLine());
                    int secondInteger = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInteger, secondInteger));
                    break;
                case "char":
                    char firstCharacter = char.Parse(Console.ReadLine());
                    char secondCharacter = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstCharacter, secondCharacter));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
                default:
                    break;
            }
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
