using System;

namespace _07.SentenceTheThief
{
    class SentenceTheThief
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

            double sentence = 0;

            if (id >= 0)
            {
                sentence = Math.Ceiling(1.0 * id / sbyte.MaxValue);
            }
            else
            {
                sentence = Math.Ceiling(1.0 * id / sbyte.MinValue);
            }
            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {sentence} year");
            }
        }
    }
}
