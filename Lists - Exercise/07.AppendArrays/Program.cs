using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> @list = Console.ReadLine()
                .Split('|')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            @list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                string[] curentElement = list[0]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                @list.Add(string.Join(" ", curentElement));
                @list.RemoveAt(0);
            }
            Console.WriteLine(string.Join(" ", @list));
        }
    }
}
