using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                string[] filePath = Console.ReadLine()
                    .Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                string[] fileInfo = filePath[filePath.Length - 1]
                    .Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);

                string root = filePath[0];
                string fileName = fileInfo[0].Trim();
                long size = long.Parse(fileInfo[1].Trim());             

                Dictionary<string, long> currentFile = new Dictionary<string, long>();
                currentFile.Add(fileName, size);

                if (!files.ContainsKey(root))
                {
                    files.Add(root, currentFile);
                }
                else
                {
                    if (files[root].ContainsKey(fileName))
                    {
                        files[root][fileName] = size;
                    }
                    else
                    {
                        files[root].Add(fileName, size);
                    }
                }
            }

            string[] command = Console.ReadLine().Split();
            string extensionToCheck = command[0];
            string rootToCheck = command[2];
            bool filesFound = false;

            foreach (var pair in files.Where(x => x.Key == rootToCheck))
            {
                foreach (var file in pair.Value
                    .Where(x => x.Key.EndsWith($"{extensionToCheck}"))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                    filesFound = true;
                }
            }

            if (!filesFound)
            {
                Console.WriteLine("No");
            }

        }
    }
}
