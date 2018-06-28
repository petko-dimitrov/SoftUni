﻿using System;

namespace TestApp
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeId = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
