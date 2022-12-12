uusing System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] getFibonacci = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 1;
                if (i > 1)
                {
                    sum = getFibonacci[i - 1] + getFibonacci[i - 2];
                }

                getFibonacci[i] = sum;
            }

            Console.WriteLine(getFibonacci[n - 1]);
        }
    }
}
