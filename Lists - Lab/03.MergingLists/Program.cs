using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> num2 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> newList = new List<int>();

            int n = Math.Min(num1.Count, num2.Count);

            for (int i = 0; i < n; i++)
            {
                newList.Add(num1[i]);
                newList.Add(num2[i]);
            }

            if(num1.Count > num2.Count)
            {
                for (int i = n; i < num1.Count; i++)
                {
                    newList.Add(num1[i]);
                }
            }
            else if (num1.Count < num2.Count)
            {
                for (int i = n; i < num2.Count; i++)
                {
                    newList.Add(num2[i]);
                }
            }
            Console.WriteLine(string.Join( " ", newList));
        }
    }
}
