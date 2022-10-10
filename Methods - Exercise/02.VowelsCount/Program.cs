using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintOutTheNumberOfVolwels(input);
        }

        static void PrintOutTheNumberOfVolwels(string input)
        {
            int counter = 0;
            for (int i = 0; i <= input.Length-1; i++)
            {
                
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O' || input[i] == 'u' || input[i] == 'U' || input[i] == 'y' || input[i] == 'Y')
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
