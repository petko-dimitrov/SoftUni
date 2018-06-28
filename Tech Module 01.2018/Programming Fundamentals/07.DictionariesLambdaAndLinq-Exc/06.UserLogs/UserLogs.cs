using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, Dictionary<string, int>> userLogs = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string username = input[2].Remove(0, 5);
                string ip = input[0].Remove(0, 3);
                Dictionary<string, int> currentIp = new Dictionary<string, int>();

                if (!userLogs.ContainsKey(username))
                {
                    currentIp.Add(ip, 1);
                    userLogs.Add(username, currentIp);
                }
                else
                {
                    if (!userLogs[username].ContainsKey(ip))
                    { 
                        userLogs[username].Add(ip, 1);
                    }
                    else
                    {
                        userLogs[username][ip]++;
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach (var pair in userLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}:");
                List<string> currentUser = new List<string>(); 
                foreach (var ip in pair.Value)
                {
                    currentUser.Add($"{ip.Key} => {ip.Value}");
                }
                Console.WriteLine(string.Join(", ", currentUser) + ".");
            }
        }
    }
}
