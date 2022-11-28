using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            int times = int.Parse(Console.ReadLine());
            Regex barcodRegex = new Regex(pattern);
            Regex numberRegex = new Regex(@"\d+");

            for (int i = 0; i < times; i++)
            {
                string input = Console.ReadLine();

                Match mache = barcodRegex.Match(input);

                if (mache.Success)
                {
                    MatchCollection numberMatch = numberRegex.Matches(mache.Value);

                    if (numberMatch.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", numberMatch)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
