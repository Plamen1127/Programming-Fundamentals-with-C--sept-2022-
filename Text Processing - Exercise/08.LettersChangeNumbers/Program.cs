using System;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string number = string.Empty;
                double currSum = 0;

                foreach (var item in input[i])
                {
                    if (char.IsDigit(item))
                    {
                        number += item;
                    }
                }

                char firstLetter = char.Parse(input[i].Substring(0, 1));
                char lastLetter = char.Parse(input[i].Substring(input[i].Length - 1, 1));

                if (char.IsLetter(firstLetter))
                {
                    if (char.IsUpper(firstLetter))
                    {
                        int cNumber = firstLetter - 64;
                        currSum += double.Parse(number) / cNumber;
                    }
                    else
                    {
                        int cNumber = firstLetter - 96;
                        currSum += double.Parse(number) * cNumber;
                    }

                    if (char.IsUpper(lastLetter))
                    {
                        int cNumber = lastLetter - 64;
                        currSum -= cNumber;

                    }
                    else
                    {
                        int cNumber = lastLetter - 96;
                        currSum += cNumber;
                    }
                }

                totalSum += currSum;

            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}