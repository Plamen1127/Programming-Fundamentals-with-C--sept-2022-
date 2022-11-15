using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;


            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar > char1 && currentChar < char2)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
