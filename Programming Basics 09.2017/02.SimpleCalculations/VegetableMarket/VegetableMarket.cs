using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            double income = vegetablePrice * vegetables + fruitPrice * fruits;
            double incomeEUR = Math.Round(income / 1.94, 2);
            Console.WriteLine(incomeEUR);
        }
    }
}
