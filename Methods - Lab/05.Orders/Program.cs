using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            
                                                                                                                                                                        NewMethod(product, qty);

        }

        private static int NewMethod(string product, int qty)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2.00;
            }
            Console.WriteLine($"{qty * price:f2}");
            
        }
    }
}
