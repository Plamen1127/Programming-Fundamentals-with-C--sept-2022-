using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string lettersPatter = @"([#$%*&])([A-Z]+)\1";

            string symbols = Regex.Match(firstPart, lettersPatter).Groups[2].ToString();

            for (int i = 0; i < symbols.Length; i++)
            {
                int length = int.Parse(Regex.Match(secondPart, $@"{(int)symbols[i]}:([0-9]{{2}})").Groups[1].ToString());
                string word = Regex.Match(thirdPart, $@"(?<=\s|^){symbols[i]}[^\s]{{{length}}}(?=\s|$)").ToString();

                Console.WriteLine(word);
            }

        }
    }
}