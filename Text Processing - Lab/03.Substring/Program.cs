using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(specialWord))
            {
                int startIndex = text.IndexOf(specialWord);
                text = text.Remove(startIndex, specialWord.Length);
                //text = text.Replace(specialWord, string.Empty);    this also works
            }

            Console.WriteLine();
        }
    }
}
