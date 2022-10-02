using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] array2 = new int[array.Length - 1];

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length-i; j++)
                {
                    array2[j] = array[i] + array[i + 1];
                }
                array = array2;
            }
            Console.WriteLine(array2);
        }
    }
}
