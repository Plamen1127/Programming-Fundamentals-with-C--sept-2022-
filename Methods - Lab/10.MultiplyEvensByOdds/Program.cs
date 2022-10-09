using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);

            int totalSum = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            Console.WriteLine(totalSum);

        }
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            int digit = num;

            while (digit > 0)
            {
                int currentDigit = digit % 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;

                }
                digit = digit / 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            int digit = num;

            while (digit > 0)
            {
                int currentDigit = digit % 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;

                }
                digit = digit / 10;
            }
            return sum;
        }
    }
}
