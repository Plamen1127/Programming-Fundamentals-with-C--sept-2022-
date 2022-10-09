using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <=num; i++)
            {
                PrintColums(i); 
            }
            for (int i = num - 1; i >= 1; i--)
            {
                PrintColums(i);
            }
        }

        private static void PrintColums(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
