using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();
            Dictionary<string, string> users = new Dictionary<string, string>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] userInfo = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = userInfo[0].Trim();
                    string forceUser = userInfo[1].Trim();

                    if (!users.ContainsKey(forceUser))
                    {
                        users.Add(forceUser, forceSide);

                        if (!book.ContainsKey(forceSide))
                        {
                            List<string> currentUser = new List<string>();
                            currentUser.Add(forceUser);
                            book.Add(forceSide, currentUser);
                        }

                        else
                        {
                            book[forceSide].Add(forceUser);
                        }
                    }
                }

                else if(input.Contains(" -> "))
                {
                    string[] userInfo = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = userInfo[0].Trim();
                    string forceSide = userInfo[1].Trim();

                    if (users.ContainsKey(forceUser))
                    {
                        string pastSide = users[forceUser];
                        users[forceUser] = forceSide;
                        book[pastSide].Remove(forceUser);

                        if (!book.ContainsKey(forceSide))
                        {
                            List<string> currentUser = new List<string>();
                            currentUser.Add(forceUser);
                            book.Add(forceSide, currentUser);
                        }
                        else
                        {
                            book[forceSide].Add(forceUser);
                        }
                    }
                    else
                    {
                        users.Add(forceUser, forceSide);

                        if (!book.ContainsKey(forceSide))
                        {
                            List<string> currentUser = new List<string>();
                            currentUser.Add(forceUser);
                            book.Add(forceSide, currentUser);
                        }
                        else
                        {
                            book[forceSide].Add(forceUser);
                        }
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var side in book
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .Where(x => x.Value.Count > 0))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
