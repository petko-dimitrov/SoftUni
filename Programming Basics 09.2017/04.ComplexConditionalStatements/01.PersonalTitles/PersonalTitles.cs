﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());            
            if (gender == 'm')
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (gender == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
