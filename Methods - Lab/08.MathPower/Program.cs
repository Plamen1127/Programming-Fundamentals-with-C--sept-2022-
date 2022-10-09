using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPawer(@base, power));
            Console.WriteLine(RaiseToPawer(@base, 3 ));
            Console.WriteLine(RaiseToPawer());


        }
        static double RaiseToPawer(double @base = 1 , double power = 4)
        {
            //double result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= @base;
            //}
            //return result;

            double result = Math.Pow(@base, power);
            return result;
        }
    }
}
