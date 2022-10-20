using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();



            while (numbers.Contains(bomb[0]))
            {

                for (int i = 0; i <= numbers.Count - 1; i++)
                {
                    int firstIndex = 0;
                    int secondIndex = 0;

                    if (numbers[i] == bomb[0])
                    {
                        if (i - bomb[1] < 0)
                        {
                            firstIndex = 0;
                        }
                        else
                        {
                            firstIndex = i - bomb[1];
                        }
                        if (i + bomb[1] > numbers.Count - 1)
                        {
                            secondIndex = numbers.Count - 1;
                        }
                        else
                        {
                            secondIndex = i + bomb[1];
                        }
                        for (int j = firstIndex; j <= secondIndex; j++)
                        {
                            numbers.RemoveAt(firstIndex);
                        }
                    }
                }
            }
            Console.WriteLine(numbers.Sum());


        }
    }
}
