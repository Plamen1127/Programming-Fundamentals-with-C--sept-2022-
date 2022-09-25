using System;

namespace _02.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double lastDidgit =Math.Abs (n % 10);

            if (lastDidgit == 1 || lastDidgit == -1)
            {
                Console.WriteLine("one");
            }
            else if (lastDidgit == 2 || lastDidgit == -2)
            {
                Console.WriteLine("two");
            }
            else if (lastDidgit == 3 || lastDidgit == -3)
            {
                Console.WriteLine("three");
            }
            else if (lastDidgit == 4 || lastDidgit == -4)
            {
                Console.WriteLine("four");
            }
            else if (lastDidgit == 5 || lastDidgit == -5)
            {
                Console.WriteLine("five");
            }
            else if (lastDidgit == 6 || lastDidgit == -6)
            {
                Console.WriteLine("six");
            }
            else if (lastDidgit == 7 || lastDidgit == -7)
            {
                Console.WriteLine("seven");
            }
            else if (lastDidgit == 8 || lastDidgit == -8)
            {
                Console.WriteLine("eight");
            }
            else if (lastDidgit == 9 || lastDidgit == -9)
            {
                Console.WriteLine("nine");
            }
            else if (lastDidgit == 0 )
            {
                Console.WriteLine("zero");
            }

        }
    }
}
