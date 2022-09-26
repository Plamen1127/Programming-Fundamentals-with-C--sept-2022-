

namespace _02.SumDigits
{
    using System;
    using System.Numerics;
    `
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger numCopy = num;
            BigInteger sum = 0;

            while(numCopy > 0)
            {
                BigInteger lastDigit = numCopy % 10;
                numCopy /= 10;
                sum += lastDigit;
            }

            Console.WriteLine(sum);

        }
    }
}
