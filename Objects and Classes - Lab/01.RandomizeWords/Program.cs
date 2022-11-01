using System;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Random ramdom = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int remdonIndex = ramdom.Next(0, words.Length);

                string curendWord = words[i];

                words[i] = words[remdonIndex];
                words[remdonIndex] = curendWord;
                
            }
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
