using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            ReadProducts(numberOfProducts, products);
            List<Customer> customers = new List<Customer>();

            string order = Console.ReadLine();

            while (order != "end of clients")
            {
                string[] orderArgs = order.Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = orderArgs[0];
                string product = "";
                int quantity = 0;
                Customer customer = new Customer();
                Dictionary<string, int> currentOrder = new Dictionary<string, int>();
                for (int i = 1; i < orderArgs.Length; i += 2)
                {
                    product = orderArgs[i];
                    quantity = int.Parse(orderArgs[i + 1]);

                    if (!customers.Any(x => x.Name == name))
                    {
                        customer.Name = name;
                        customer.Bill = 0;
                        if (products.ContainsKey(product))
                        {
                            currentOrder.Add(product, quantity);
                            customer.Bill += quantity * products[product];
                            customer.Order = currentOrder;
                            customers.Add(customer);
                        }
                    }
                    else
                    {
                        if (products.ContainsKey(product))
                        {
                            Customer currentCustomer = customers.First(x => x.Name == name);
                            currentOrder = currentCustomer.Order;
                            if (currentOrder.ContainsKey(product))
                            {
                                currentOrder[product] += quantity;
                            }
                            else
                            {
                                currentOrder.Add(product, quantity);
                            }
                            currentCustomer.Bill += quantity * products[product];
                            currentCustomer.Order = currentOrder;
                        }
                    }
                }

                order = Console.ReadLine();
            }

            decimal totalBill = 0;

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                totalBill += customer.Bill;
                Console.WriteLine(customer.Name);

                foreach (var item in customer.Order)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        static void ReadProducts(int numberOfProducts, Dictionary<string, decimal> products)
        {
            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string product = input[0];
                decimal price = decimal.Parse(input[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, price);
                }
                else
                {
                    products[product] = price;
                }
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Order { get; set; }
        public decimal Bill { get; set; }
    }
}