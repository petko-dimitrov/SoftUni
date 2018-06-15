using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int pieces = width * height;
            int piecesLeft = pieces;

            while (piecesLeft >= 0)
            {
                string piecesTaken = Console.ReadLine();
                
                if (piecesTaken == "STOP")
                {
                    break;
                }
                piecesLeft -= Convert.ToInt32(piecesTaken);
            }
            if (piecesLeft > 0)
            {
                Console.WriteLine("{0} pieces are left.", piecesLeft);
            }
            else
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(piecesLeft));
            }
        }
    }
}
