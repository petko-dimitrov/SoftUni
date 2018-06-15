using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.PhotoPictures
{
    class PhotoPictures
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string typeOfOrder = Console.ReadLine().ToLower();
            double price = 0.0;

            switch (type)
            {
                case "9x13":
                    if (pictures >= 50)
                    {
                        price = pictures * 0.16 * 0.95;
                    }
                    else
                    {
                        price = pictures * 0.16;
                    }
                    break;
                case "10x15":
                    if (pictures >= 80)
                    {
                        price = pictures * 0.16 * 0.97;
                    }
                    else
                    {
                        price = pictures * 0.16;
                    }
                    break;
                case "13x18":
                    if (pictures >= 50 && pictures <= 100)
                    {
                        price = pictures * 0.38 * 0.97;
                    }
                    else if (pictures > 100)
                    {
                        price = pictures * 0.38 * 0.95;
                    }
                    else
                    {
                        price = pictures * 0.38;
                    }
                    break;
                case "20x30":
                    if (pictures >= 10 && pictures <= 50)
                    {
                        price = pictures * 2.9 * 0.93;
                    }
                    else if (pictures > 50)
                    {
                        price = pictures * 2.9 * 0.91;
                    }
                    else
                    {
                        price = pictures * 2.9;
                    }
                    break;
                default:
                    break;
            }
            if (typeOfOrder == "online")
            {
                price = price * 0.98;
            }
            Console.WriteLine("{0:f2}BGN", price);
        }
    }
}
