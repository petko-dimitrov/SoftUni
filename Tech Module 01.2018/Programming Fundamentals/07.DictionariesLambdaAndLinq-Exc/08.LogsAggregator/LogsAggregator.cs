using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] logInfo = Console.ReadLine().Split();
                string user = logInfo[1];
                string ip = logInfo[0];
                int duration = int.Parse(logInfo[2]);
                Dictionary<string, int> currentLog = new Dictionary<string, int>();
                currentLog.Add(ip, duration);

                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, currentLog);
                }
                else
                {
                    if (!logs[user].ContainsKey(ip))
                    {
                        logs[user].Add(ip, duration);
                    }
                    else
                    {
                        logs[user][ip] += duration;
                    }
                }
            }

            foreach (var pair in logs.OrderBy(x => x.Key))
            {
                Console.Write($"{pair.Key}: {pair.Value.Values.Sum()} ");
                List<string> ips = new List<string>();
                foreach (var ip in pair.Value)
                {
                    ips.Add(ip.Key);
                }
                Console.WriteLine("[{0}]", string.Join(", ", ips.OrderBy(x => x)));
            }
        }
    }
}
