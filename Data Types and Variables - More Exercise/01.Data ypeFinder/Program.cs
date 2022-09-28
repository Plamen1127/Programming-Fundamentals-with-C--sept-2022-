using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___More_Exercise28_._09
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }

                else if (double.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                }

                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }

                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }

                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
