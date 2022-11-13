using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.WriteLine(SumOfCharactersCodes(input[0], input[1]));



        }
        static int SumOfCharactersCodes(string str1, string str2)
        {
            int sum = 0;
            string longString = string.Empty;
            string shortString = string.Empty;

            if (str1.Length > str2.Length)
            {
                longString = str1;
                shortString = str2;
            }
            else
            {
                longString = str2;
                shortString = str1;
            }

            for (int i = 0; i < shortString.Length; i++)
            {
                char curentChar1 = longString[i];
                char curentChar2 = shortString[i];

                sum += curentChar1 * curentChar2;
            }

            for (int i = shortString.Length; i <= longString.Length-1; i++)
            {
                char curentChar1 = longString[i];

                sum += curentChar1;
            }


            return sum;
        }

    }
}
