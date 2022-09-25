using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            int numCopy = num;
            while (numCopy>0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int sum = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    sum *= i;
                }

                total += sum;
            }

            if (total == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            

       
        }
    }
}
