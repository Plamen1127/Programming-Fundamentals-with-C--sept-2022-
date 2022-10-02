using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrays2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < arrays1.Length; i++)
            {
                for (int k = i; k == i; k++)
                {
                    if (arrays1[i] == arrays2[k])
                    {
                        sum += arrays1[i];
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
