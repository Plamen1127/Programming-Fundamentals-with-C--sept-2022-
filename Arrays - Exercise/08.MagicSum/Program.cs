using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i]+ array[k] == number)
                    {
                        int[] newAraay = { array[i], array[k] };
                        Console.WriteLine(string.Join(" ", newAraay));
                    }
                }
            }
        }
    }
}
