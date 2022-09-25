using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length-1; i >= 0; i--)
            {
                char simbol = input[i];
                Console.Write(simbol);
            }
        }
    }
}
