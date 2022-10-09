using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int area = CalculateAreaRectangl(num1, num2);
            Console.WriteLine(area);
        }
        static int CalculateAreaRectangl(int a, int b)
        {
            return a * b;
        }
    }
}
