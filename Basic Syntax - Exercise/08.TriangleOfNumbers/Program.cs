using System;

namespace _08.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            for (int i = 1; i <= n; i++)
            {
                if(type == "Equilateral")
                {
                    int qtySpeis = n - i;
                    for (int speis = 1; speis <= qtySpeis; speis++)
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
