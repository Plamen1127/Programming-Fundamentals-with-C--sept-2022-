using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split()
                .ToArray();

            string[] secundArray = Console.ReadLine()
                .Split()
                .ToArray();


            for (int i = 0; i < secundArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secundArray[i] == firstArray[j])
                    {
                        Console.Write($"{secundArray[i]} ");
                    }
                }
            }
        }
    }
}
