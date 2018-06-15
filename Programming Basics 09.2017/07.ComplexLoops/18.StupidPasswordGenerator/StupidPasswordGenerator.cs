using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (var k = 'a'; k < 'a' + l; k++)
                    {
                        for (var m = 'a'; m < 'a' + l; m++)
                        {
                            for (int z = 1; z <= n; z++)
                            {
                                if (z > i && z > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}", i, j, k, m, z);
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
            }            
        }
    }
}
