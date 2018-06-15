using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorHeight = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileH = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double workerMoney = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorHeight;
            double tileArea = tileSide * tileH / 2;
            double tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;
            double moneyNeeded = tilesNeeded * tilePrice + workerMoney;

            if (moneyNeeded <= savedMoney)
            {
                Console.WriteLine("{0:f2} lv left.", savedMoney - moneyNeeded);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", moneyNeeded - savedMoney);
            }
        }
    }
}
