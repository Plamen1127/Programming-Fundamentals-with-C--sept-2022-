using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtyLines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();


            for (int i = 0; i < qtyLines; i++)
            {

                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonym);

            }
            foreach (var wordSinonyms in words)
            {
                Console.WriteLine($"{wordSinonyms.Key} - {string.Join(", ", wordSinonyms.Value)}");
            }

        }

    }
}
