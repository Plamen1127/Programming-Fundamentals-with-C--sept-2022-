using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)                         //2 1 1 2 3 3 2 2 2 1
                               .ToArray();
            int counter = 0;
            int winningCounter = 0;
         
            int number = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int show = numbers[i];
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > winningCounter)
                    {
                        winningCounter = counter;
                        number = numbers[i];
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= winningCounter; i++)
            {
                Console.Write($"{number} ");
            }



        }
    }
    
}
