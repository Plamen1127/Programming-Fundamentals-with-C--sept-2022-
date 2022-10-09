using System;

namespace _01.SignОfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NewMethod(n);
        }

        private static void NewMethod(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive. ");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero. ");
            }
        }
    }
}
