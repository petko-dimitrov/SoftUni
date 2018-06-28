using System;

namespace _01.PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            decimal availableMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsabrePrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            int freeBelts = studentsCount / 6;
            int beltsCount = studentsCount - freeBelts;
            double lightSabreCount = Math.Ceiling(studentsCount * 1.1);
            decimal totalMoneyNeeded = (decimal)lightSabreCount * lightsabrePrice
                + studentsCount * robePrice + beltsCount * beltPrice;

            if (availableMoney >= totalMoneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoneyNeeded - availableMoney):f2}lv more.");
            }
        }
    }
}
