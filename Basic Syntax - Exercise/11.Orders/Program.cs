using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyOrders = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 1; i <=qtyOrders; i++)
            {
                double allPrice = 0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int qtyCapsules = int.Parse(Console.ReadLine());
                allPrice = (days * qtyCapsules) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${allPrice:F2}");
                totalSum += allPrice;
            }
            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
