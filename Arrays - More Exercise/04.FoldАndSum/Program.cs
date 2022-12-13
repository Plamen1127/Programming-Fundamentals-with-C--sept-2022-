using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;
            int[] newArray = new int[numbers.Length / 2];

            for (int i = 0; i < k; i++)
            {
                newArray[i] = numbers[i + k] + numbers[k - 1 - i];
                newArray[i + k] = numbers[i + 2 * k] + numbers[numbers.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
