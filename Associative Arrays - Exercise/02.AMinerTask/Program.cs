using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            string resurce = Console.ReadLine();

            while( resurce != "stop")
            {
                int qty = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resurce))
                {
                    items.Add(resurce, 0);
                }

                items[resurce] += qty;

                resurce = Console.ReadLine();
            }
            foreach (var curentItem in items)
            {
                Console.WriteLine($"{curentItem.Key} -> {curentItem.Value}");
            }
        }
    }
}
