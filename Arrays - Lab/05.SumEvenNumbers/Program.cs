using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nubmers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < nubmers.Length; i++)
            {
                if ( nubmers[i] % 2 == 0)
                {
                    sum += nubmers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
