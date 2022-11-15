using System;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyLines = int.Parse(Console.ReadLine());


            for (int i = 0; i < qtyLines; i++)
            {
                string person = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;
                int startName = person.IndexOf('@') + 1;
                int endName = person.IndexOf('|');
                int startAge = person.IndexOf('#') + 1;
                int endAge = person.IndexOf('*');

                for (int k = startName; k < endName; k++)
                {
                    name += person[k];
                }
                for (int l = startAge; l < endAge; l++)
                {
                    age += person[l];
                }

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
