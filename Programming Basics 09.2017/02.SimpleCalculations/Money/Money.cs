using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine()) / 100;
            double yuanToLev = yuan * 0.15 * 1.76;
            double bitcoinToLev = bitcoins * 1168;
            double levToEuro = (yuanToLev + bitcoinToLev) / 1.95;
            double total = levToEuro - commission * levToEuro;
            Console.WriteLine(total);
        }
    }
}
