using System;

namespace _15.BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            string currentBracket = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == ")" && currentBracket == "")
                {
                    isBalanced = false;
                }
                else if (currentBracket == "(" && input == "(")
                {
                    isBalanced = false;
                }
                else if (currentBracket == ")" && input == ")")
                {
                    isBalanced = false;
                }
                else if (input == "(")
                {
                    currentBracket = "(";
                }
                else if (input == ")")
                {
                    currentBracket = ")";
                }
            }

            if (currentBracket == "" || currentBracket == "(")
            {
                isBalanced = false;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
