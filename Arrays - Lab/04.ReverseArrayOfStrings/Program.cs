using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                .Split()
                .ToArray();


            for (int i = elements.Length - 1; i >= 0; i--)
            {
                Console.Write($"{elements[i]} ");
            }
        }
    }
}
