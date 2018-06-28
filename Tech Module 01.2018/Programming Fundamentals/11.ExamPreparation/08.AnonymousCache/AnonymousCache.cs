using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> datasets = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                string[] data = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (data.Length == 1 && !datasets.ContainsKey(data[0]))
                {
                    if (cache.ContainsKey(data[0]))
                    {
                        datasets.Add(data[0], cache[data[0]]);
                    }
                    else
                    {
                        datasets.Add(data[0], new Dictionary<string, long>());
                    }
                }
                else
                {
                    string datakey = data[0];
                    long datasize = long.Parse(data[1]);
                    string dataset = data[2];
                    Dictionary<string, long> currentSet = new Dictionary<string, long>();
                    currentSet.Add(datakey, datasize);

                    if (!datasets.ContainsKey(dataset))
                    {
                        if (!cache.ContainsKey(dataset))
                        {
                            cache.Add(dataset, currentSet);
                        }
                        else
                        {
                            cache[dataset].Add(datakey, datasize);
                        }
                    }

                    else
                    {
                        datasets[dataset].Add(datakey, datasize);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var set in datasets.OrderByDescending(x => x.Value.Values.Sum()).Take(1))
            {
                Console.WriteLine($"Data Set: {set.Key}, Total Size: {set.Value.Values.Sum()}");
                foreach (var pair in set.Value)
                {
                    Console.WriteLine($"$.{pair.Key}");
                }
            }
        }
    }
}
