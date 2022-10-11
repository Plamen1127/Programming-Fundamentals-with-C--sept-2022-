using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(MiddleCharacters(input));

        }

        static string MiddleCharacters(string input)
        {
            string midle = string.Empty;
            if (input.Length % 2 == 0)
            {
                midle = input[input.Length / 2].ToString();

            }
            else
            {
                midle = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            return midle;
        }
    }
}
