using System;

namespace _18.DifferentIntegerSize
{
    class DifferentIntegerSize
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            try
            {
                long temp = long.Parse(number);
            }
            catch (Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
                return;
            }

            Console.WriteLine($"{number} can fit in:");
            try
            {
                sbyte temp = sbyte.Parse(number);
                Console.WriteLine("* sbyte");
            }
            catch (Exception)
            {}
            try
            {
                byte temp = byte.Parse(number);
                Console.WriteLine("* byte");
            }
            catch (Exception)
            {
                
            }
            try
            {
                short temp = short.Parse(number);
                Console.WriteLine("* short");
            }
            catch (Exception)
            {
                
            }
            try
            {
                ushort temp = ushort.Parse(number);
                Console.WriteLine("* ushort");
            }
            catch (Exception)
            {
                
            }
            try
            {
                int temp = int.Parse(number);
                Console.WriteLine("* int");
            }
            catch (Exception)
            {
                
            }
            try
            {
                uint temp = uint.Parse(number);
                Console.WriteLine("* uint");
            }
            catch (Exception)
            {
                
            }

            Console.WriteLine("* long");          
        }
    }
}
