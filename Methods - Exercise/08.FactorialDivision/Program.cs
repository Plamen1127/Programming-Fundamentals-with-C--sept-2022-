using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = Facturiel(num1) / Facturiel(num2);
            Console.WriteLine($"{result:f2}");

        }

        static double Facturiel( double num1)
        {
            double sum = 1;
            for (int i = 1; i <=num1; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
