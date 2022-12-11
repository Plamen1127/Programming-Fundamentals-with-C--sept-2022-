using System;
using System.Linq;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                int number = 1;

                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{number} ");
                    number = number * (row - col) / (col + 1);
                }

                Console.WriteLine();
            }

        }
    }
}
