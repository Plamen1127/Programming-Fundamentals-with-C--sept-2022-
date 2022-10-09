using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(num1, @operator, num2));

        }

        static double Calculation(int num1, string @operator, int num2)
        {
            double result = 0;
            if (@operator == "/")
            {
                result = num1 / num2;
                
            }

            else if (@operator == "*")
            {
                result = num1 * num2;
                
            }

            else if (@operator == "+")
            {
                result = num1 + num2;
                
            }

            else if (@operator == "-")
            {
                result = num1 - num2;
                
            }
            return result;
        }
    }
}
