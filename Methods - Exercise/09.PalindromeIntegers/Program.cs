using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

         
            while ( input != "END")
            {
                Console.WriteLine(IsNumberPolindrome(input));
                input = Console.ReadLine();
            }


            



        }
        static bool IsNumberPolindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string first = input[i].ToString();
                string second = input[input.Length - 1 - i].ToString();

                if (first != second)
                {
                    return false;
                }
            }
            return true;



        }
    }
}
