using System;
using System.Numerics;

namespace _05.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int numberOfSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            BigInteger securityToken = BigInteger.Pow(securityKey, numberOfSites);
            decimal totalLoss = 0;

            for (int i = 0; i < numberOfSites; i++)
            {
                string[] siteInfo = Console.ReadLine().Split();
                string siteName = siteInfo[0];
                uint siteVisits = uint.Parse(siteInfo[1]);
                decimal pricePerVisit = decimal.Parse(siteInfo[2]);

                Console.WriteLine(siteName);
                totalLoss += siteVisits * pricePerVisit;
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
