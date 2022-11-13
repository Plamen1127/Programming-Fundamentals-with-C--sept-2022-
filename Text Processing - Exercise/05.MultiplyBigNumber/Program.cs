using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = int.Parse(Console.ReadLine());
            StringBuilder finalNumbers = new StringBuilder();

            if (input == "0" || power == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int leftOver = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {

                int currentNum = int.Parse(input[i].ToString());
                int multiply = currentNum * power + leftOver;
                int result = multiply % 10;
                leftOver = multiply / 10;
                finalNumbers.Insert(0, result);
            }

            if (leftOver > 0)
            {
                finalNumbers.Insert(0, leftOver);
            }

            Console.WriteLine(finalNumbers);
        }
    }
}
