﻿using System;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = people / capacity;
            if (people % capacity != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }   
    }       
}           
