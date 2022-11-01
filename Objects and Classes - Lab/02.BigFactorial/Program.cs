using System;
using System.Numerics;

namespace _02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int nuber = int.Parse(Console.ReadLine());
            BigInteger factorialResult = 1;
            for (int n = 1; n <= nuber; n++)
            {
                factorialResult *= n;
            }
            Console.WriteLine(factorialResult);
        }
    }
}
