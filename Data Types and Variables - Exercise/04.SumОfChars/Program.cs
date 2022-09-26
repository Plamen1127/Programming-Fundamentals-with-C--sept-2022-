using System;

namespace _04.SumОfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n ; i++)
            {
                char cha = char.Parse(Console.ReadLine());

                sum += (int)cha;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
