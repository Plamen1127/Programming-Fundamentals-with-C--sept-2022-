using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int curentSum = numbers[i] + numbers[numbers.Count-1- i];
                newList.Add(curentSum);
            }

            if (numbers.Count % 2 != 0)
            {
                newList.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
