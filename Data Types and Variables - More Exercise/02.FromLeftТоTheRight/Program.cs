namespace _02.FromLeftToTheRight
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                string input = Console.ReadLine();
                string leftNumber = "";
                string rightNumber = "";
                int counter = 0;

                for (int j = 0; j < input.Length - 1; j++)
                {
                    char sumbul = input[j];
                    if (sumbul != ' ')
                    {
                        leftNumber += sumbul;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int k = counter + 1; k < input.Length; k++)
                {
                    char symbul = input[k];
                    if (symbul != ' ')
                    {
                        rightNumber += symbul;
                    }
                }
                BigInteger leftSide = BigInteger.Parse(leftNumber);
                BigInteger rightSide = BigInteger.Parse(rightNumber);
                BigInteger sum = 0;

                if (leftSide >= rightSide)
                {
                    while (BigInteger.Abs(leftSide) > 0)
                    {
                        sum += leftSide % 10;
                        leftSide /= 10;
                    }
                }
                else if (rightSide >= leftSide)
                {
                    while (BigInteger.Abs(rightSide) > 0)
                    {
                        sum += rightSide % 10;
                        rightSide /= 10;
                    }

                }
                Console.WriteLine(BigInteger.Abs(sum));

            }

        }
    }
}
