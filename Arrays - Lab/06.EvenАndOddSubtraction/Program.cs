using System;
using System.Linq;

namespace _06.EvenАndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double evenSum = 0;
            double oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    oddSum += numbers[i];
                }
            }

            Console.WriteLine(evenSum-oddSum);
        }
    }
}
