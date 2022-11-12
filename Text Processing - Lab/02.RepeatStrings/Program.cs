using System;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            StringBuilder result = new StringBuilder();

            foreach (var curentWord in words)
            {
                for (int i = 0; i < curentWord.Length; i++)
                {
                    result.Append(curentWord);
                }
            }
            Console.WriteLine(result);
        }
    }
}
