using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namesDistance = Console.ReadLine().Split(", ")
                                                   .ToDictionary(x => x, x => 0);

            string lettersPattern = "[A-Za-z]";
            string digitsPattern = "[0-9]";
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection letters = Regex.Matches(input, lettersPattern);
                MatchCollection digits = Regex.Matches(input, digitsPattern);

                string name = string.Join("", letters);
                int distance = digits.Select(x => x.ToString())
                                     .Select(int.Parse)
                                     .Sum();

                if (namesDistance.ContainsKey(name))
                {
                    namesDistance[name] += distance;
                }

                input = Console.ReadLine();
            }

            List<string> names = namesDistance.OrderByDescending(x => x.Value)
                                              .Select(x => x.Key)
                                              .ToList();

            Console.WriteLine($"1st place: {names[0]}");
            Console.WriteLine($"2nd place: {names[1]}");
            Console.WriteLine($"3rd place: {names[2]}");

        }
    }
}