using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> product = new List<string>();

            for (int i = 1; i <=n; i++)
            {
                product.Add(Console.ReadLine());
            }

            product.Sort();

            for (int i = 0; i <= product.Count-1; i++)
            {
                Console.WriteLine($"{i+1}.{product[i]}");
            }
        }
    }
}
