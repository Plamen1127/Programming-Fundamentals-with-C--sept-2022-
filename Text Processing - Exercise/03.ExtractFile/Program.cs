using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string fileName = input.Split('\\').Last().Split('.').First();

            string extension = input.Split('\\').Last().Split('.').Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
