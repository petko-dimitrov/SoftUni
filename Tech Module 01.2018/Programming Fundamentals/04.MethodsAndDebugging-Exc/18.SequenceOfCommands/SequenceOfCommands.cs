using System;
using System.Linq;

public class SequenceOfCommands_broken
{

    public static void Main()
    {
        const char ArgumentsDelimiter = ' ';
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = "";

        while (!command.Equals("stop"))
        {
            command = Console.ReadLine().Trim();
            string[] commandParams = command.Split(ArgumentsDelimiter);
            int[] elementAndValue = new int[2];

            if (commandParams[0] != "lshift" && commandParams[0] != "rshift" && commandParams[0] != "stop")
            {
                elementAndValue[0] = int.Parse(commandParams[1]);
                elementAndValue[1] = int.Parse(commandParams[2]);
            }

            PerformAction(array, commandParams[0], elementAndValue);
            if (commandParams[0] != "stop")
            {
                PrintArray(array);
            }
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        //long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos-1] *= value;
                break;
            case "add":
                arr[pos-1] += value;
                break;
            case "subtract":
                arr[pos-1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    static void ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
    }

    static void ArrayShiftLeft(long[] array)
    {
        long temp = array[0];
        for (int i = 0; i <= array.Length - 2; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;
    }

    static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(array[array.Length - 1]);
    }
}