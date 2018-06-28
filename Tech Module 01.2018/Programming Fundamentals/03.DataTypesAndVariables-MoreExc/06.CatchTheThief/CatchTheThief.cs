using System;

namespace _06.CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long id = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long possibleId = long.Parse(Console.ReadLine());
                switch (numeralType)
                {
                    case "sbyte":
                        if (possibleId <= sbyte.MaxValue && possibleId > sbyte.MinValue && possibleId > id)
                        {
                            id = possibleId;
                        }
                        break;
                    case "int":
                        if (possibleId <= int.MaxValue && possibleId > int.MinValue && possibleId > id)
                        {
                            id = possibleId;
                        }
                        break;
                    case "long":
                        if (possibleId <= long.MaxValue && possibleId > long.MinValue && possibleId > id)
                        {
                            id = possibleId;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(id);
        }
    }
}
