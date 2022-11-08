using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine()
                .ToCharArray();

            Dictionary<char, int> leters = new Dictionary<char, int>();

            foreach (var leter in word)
            {
                if(leter != ' ')
                {
                    if (!leters.ContainsKey(leter))
                    {
                        leters.Add(leter, 0);
                    }
                    leters[leter]++;
                }
               
            }
            foreach (var curent in leters)
            {
                Console.WriteLine($"{curent.Key} -> {curent.Value}");
            }
        }
    }
}
