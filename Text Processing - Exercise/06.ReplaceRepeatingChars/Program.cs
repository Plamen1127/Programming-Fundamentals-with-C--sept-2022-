using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder newWord = new StringBuilder();

            char curentChar = word[0];
            newWord.Append(curentChar);

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != curentChar)
                {
                    newWord.Append(word[i]);
                    curentChar = word[i];
                }
            }

            Console.WriteLine(newWord); ;
        }
    }
}
