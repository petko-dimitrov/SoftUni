using System;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100Ml = int.Parse(Console.ReadLine());
            int sugarContentPer100Ml = int.Parse(Console.ReadLine());

            double totalEnergyContent = (double)energyContentPer100Ml / 100 * volume;
            double totalSugarContent = (double)sugarContentPer100Ml / 100 * volume;

            Console.WriteLine("{0}ml {1}:", volume, name);
            // The new line can be done with \r\n
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergyContent, totalSugarContent);
        }
    }
}
