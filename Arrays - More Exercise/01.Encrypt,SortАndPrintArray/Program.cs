using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] vowel = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;

                for (int k = 0; k < input.Length; k++)
                {
                    char curentLeter = input[k];

                    if (vowel.Contains(curentLeter))
                    {
                        sum += curentLeter * input.Length;
                    }
                    else
                    {
                        sum += curentLeter / input.Length;
                    }
                }

                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(Environment.NewLine, numbers.OrderBy(x => x)));
            //  Array.Sort(numbers);
            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }

        }
    }
}
