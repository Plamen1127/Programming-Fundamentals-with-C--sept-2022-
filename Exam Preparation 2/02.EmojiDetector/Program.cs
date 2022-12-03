using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int coolThresholt = 1;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    int digit = int.Parse(ch.ToString());
                    coolThresholt *= digit;
                }
            }
            string pattrern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})\1";

            Regex regex = new Regex(pattrern);
            MatchCollection maches = regex.Matches(input);

            Console.WriteLine($"Cool threshold: {coolThresholt}");
            Console.Write($"{maches.Count} emojis found in the text. ");
            Console.WriteLine("The cool ones are:");

            foreach (Match match in maches)
            {
                string curentEmoji = match;
                int emojiSimvolsSum = 0;

                foreach (char ch in curentEmoji)
                {
                    emojiSimvolsSum += ch;
                }
                if (emojiSimvolsSum>=coolThresholt)
                {
                    Console.WriteLine($"{match}");
                }
            }


        }
    }
}
