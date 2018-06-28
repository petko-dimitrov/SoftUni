using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] saleInfo = Console.ReadLine().Split();
                sales.Add(ReadSale(saleInfo));
            }

            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < sales.Count; i++)
            {
                decimal currentSalePrice = sales[i].Quantity * sales[i].Price;

                if (!salesByTown.ContainsKey(sales[i].Town))
                {
                    salesByTown.Add(sales[i].Town, currentSalePrice);
                }
                else
                {
                    salesByTown[sales[i].Town] += currentSalePrice;
                }
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        static Sale ReadSale(string[] saleInfo)
        {
            Sale currentSale = new Sale();
            currentSale.Town = saleInfo[0];
            currentSale.Product = saleInfo[1];
            currentSale.Price = decimal.Parse(saleInfo[2]);
            currentSale.Quantity = decimal.Parse(saleInfo[3]);
            return currentSale;
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
