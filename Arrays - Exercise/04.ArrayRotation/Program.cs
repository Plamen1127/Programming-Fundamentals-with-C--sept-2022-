using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());             //51 47 32 61 21
                                                                             //2

            int timeToRotation = rotationsCount % array.Length;

            for (int i = 1; i <=timeToRotation; i++)
            {
                int firstElement = array[0];

                for (int k = 1; k < array.Length; k++)
                {
                    array[k - 1] = array[k];
                }
                array[array.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", array));

        }
    }
}
