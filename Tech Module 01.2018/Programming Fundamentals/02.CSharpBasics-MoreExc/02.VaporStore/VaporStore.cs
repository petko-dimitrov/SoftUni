using System;

namespace _02.VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            decimal totalSpent = 0;
            string game = "";

            while (game != "Game Time")
            {
                game = Console.ReadLine();
                switch (game)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            totalSpent += 39.99m;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (currentBalance >= 15.99m)
                        {
                            currentBalance -= 15.99m;
                            totalSpent += 15.99m;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance >= 19.99m)
                        {
                            currentBalance -= 19.99m;
                            totalSpent += 19.99m;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalance >= 59.99m)
                        {
                            currentBalance -= 59.99m;
                            totalSpent += 59.99m;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalance >= 29.99m)
                        {
                            currentBalance -= 29.99m;
                            totalSpent += 29.99m;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99m)
                        {
                            currentBalance -= 39.99m;
                            totalSpent += 39.99m;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Game Time":
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (currentBalance == 0m)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
