using System;
using System.Collections.Generic;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> order = new Dictionary<string, decimal>();
            Dictionary<string, int> newOrder = new Dictionary<string, int>();
            string product = Console.ReadLine();


            while (product != "buy")
            {
                string[] cmd = product.Split();
                string productName = cmd[0];
                decimal priceForProduct = decimal.Parse(cmd[1]);
                int qty = int.Parse(cmd[2]);


                if (!newOrder.ContainsKey(productName))
                {
                    order.Add(productName, priceForProduct);
                    newOrder.Add(productName, qty);
                }
                else if (order.ContainsKey(productName))
                {
                    order.Remove(productName);
                    order.Add(productName, priceForProduct);
                    newOrder[productName] += qty;
                }

                product = Console.ReadLine();
            }

            foreach (var curentOrder in order)
            {
                foreach (var curentNewOrder in newOrder)
                {
                    if (curentNewOrder.Key == curentOrder.Key)
                    {
                        Console.WriteLine($"{curentOrder.Key} -> {curentOrder.Value*curentNewOrder.Value:F2}");
                    }
                }
            }
        }
    }
}
