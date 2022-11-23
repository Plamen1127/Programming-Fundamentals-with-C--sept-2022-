using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedP = new List<string>();
            List<string> destroyedP = new List<string>();

            int n = int.Parse(Console.ReadLine());

            string pattern = @"[^\@\-\!\:\>]*?\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?:[^\@\-\!\:\>]*?(?<population>\d+)!(?<type>[A|D])![^\@\-\!\:\>]*?->(?<soldier>\d+)[^\@\-\!\:\>]*?";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(Decrypted(input));

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string type = match.Groups["type"].Value;

                    if (type == "A")
                    {
                        attackedP.Add(planet);
                    }
                    else if (type == "D")
                    {
                        destroyedP.Add(planet);
                    }

                }

            }

            Console.WriteLine($"Attacked planets: {attackedP.Count}");
            foreach (string item in attackedP.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedP.Count}");
            foreach (string item in destroyedP.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }

        static string Decrypted(string input)
        {
            StringBuilder sb = new StringBuilder();
            int counter = Counter(input);

            foreach (char item in input)
            {
                sb.Append((char)(item - counter));
            }

            return sb.ToString();
        }
        static int Counter(string input)
        {
            int counter = 0;

            foreach (char item in input.ToLower())
            {
                if (item == 's' || item == 't' || item == 'a' || item == 'r')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
