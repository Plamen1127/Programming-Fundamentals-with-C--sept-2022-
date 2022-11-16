using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> MorseCodeLetters = new Dictionary<string, char>()
            {
                {".-",  'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..", 'D'},
                {".",   'E'},
                {"..-.",'F'},
                {"--.", 'G'},
                {"....",'H'},
                {"..",  'I'},
                {".---",'J'},
                {"-.-", 'K'},
                {".-..",'L'},
                {"--",  'M'},
                {"-.",  'N'},
                {"---", 'O'},
                {".--.",'P'},
                {"--.-",'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-",   'T'},
                {"..-", 'U'},
                {"...-",'V'},
                {".--", 'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                {"--..",'Z'},
                {"|",   ' '}
            };

            List<string> codes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string message = string.Empty;

            for (int i = 0; i < codes.Count; i++)
            {
                message += MorseCodeLetters[codes[i]];
            }

            Console.WriteLine(message);
        }
    }
}
