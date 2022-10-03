using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secundArray = new int[n];


            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if ( i % 2 != 0)
                {
                    firstArray[i - 1] = numbers[0];
                    secundArray[i - 1] = numbers[1];
                }
                else
                {
                    firstArray[i-1] = numbers[1];
                    secundArray[i-1] = numbers[0];
                }



            }


            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secundArray));
        }
    }
}
