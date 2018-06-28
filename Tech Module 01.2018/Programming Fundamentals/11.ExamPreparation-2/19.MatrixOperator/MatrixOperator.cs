using System;
using System.Collections.Generic;
using System.Linq;

namespace _19.MatrixOperator
{
    class MatrixOperator
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            List<List<int>> rows = new List<List<int>>();

            for (int i = 0; i < rowsCount; i++)
            {
                List<int> currentRow = Console.ReadLine().Split().Select(int.Parse).ToList();
                rows.Add(currentRow);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "remove")
                {
                    RemoveRowsOrCols(rows, command);
                }
                else if (command[0] == "swap")
                {
                    SwapRows(rows, command);
                }
                else if (command[0] == "insert")
                {
                    InsertNumber(rows, command);
                }

                command = Console.ReadLine().Split();
            }

            for (int i = 0; i < rows.Count; i++)
            {
                Console.WriteLine(string.Join(" ", rows[i]));
            }
        }

        static void InsertNumber(List<List<int>> rows, string[] command)
        {
            int row = int.Parse(command[1]);
            int number = int.Parse(command[2]);
            rows[row].Insert(0, number);
        }

        static void RemoveRowsOrCols(List<List<int>> rows, string[] command)
        {
            string type = command[1];
            string positionType = command[2];
            int index = int.Parse(command[3]);

            if (positionType == "row")
            {
                switch (type)
                {
                    case "positive":
                        rows[index].RemoveAll(x => x >= 0);
                        break;
                    case "negative":
                        rows[index].RemoveAll(x => x < 0);
                        break;
                    case "even":
                        rows[index].RemoveAll(x => x % 2 == 0);
                        break;
                    case "odd":
                        rows[index].RemoveAll(x => x % 2 != 0);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    if (index < rows[i].Count)
                    {
                        switch (type)
                        {
                            case "positive":
                                if (rows[i][index] >= 0)
                                {
                                    rows[i].RemoveAt(index);
                                }
                                break;
                            case "negative":
                                if (rows[i][index] < 0)
                                {
                                    rows[i].RemoveAt(index);
                                }
                                break;
                            case "even":
                                if (rows[i][index] % 2 == 0)
                                {
                                    rows[i].RemoveAt(index);
                                }
                                break;
                            case "odd":
                                if (rows[i][index] % 2 != 0)
                                {
                                    rows[i].RemoveAt(index);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        static void SwapRows(List<List<int>> rows, string[] command)
        {
            int row1 = int.Parse(command[1]);
            int row2 = int.Parse(command[2]);
            List<int> temp = rows[row1];
            rows[row1] = rows[row2];
            rows[row2] = temp;
        }
    }
}
