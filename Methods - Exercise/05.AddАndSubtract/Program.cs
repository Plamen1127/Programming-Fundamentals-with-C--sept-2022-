using System;

namespace _05.AddАndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumOfTheTwoNombers(num1, num2);
            Console.WriteLine(SubtrakSumFromNum3(sum, num3));

        }

        static int SumOfTheTwoNombers(int num1, int num2)
        {
            int sumOfTwoNombers = num1 + num2;
            return sumOfTwoNombers;
        }

        static int SubtrakSumFromNum3(int sum, int num3)
        {
            int sum2 = sum - num3;
            return sum2;
        }
    }
}
