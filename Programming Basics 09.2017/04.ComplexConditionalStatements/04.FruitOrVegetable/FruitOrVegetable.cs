using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            if (item == "banana" || item == "kiwi" || item == "apple" || item == "cherry"
                || item == "lemon" || item == "grapes")
            {
                Console.WriteLine("fruit");
            }
            //tomato, cucumber, pepper и carro
            else if (item == "tomato" || item == "cucumber" || item == "pepper" || item == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
