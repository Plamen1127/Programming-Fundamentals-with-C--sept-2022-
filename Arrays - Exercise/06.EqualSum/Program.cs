using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")                                                      // 0 1 2 3  4 5 6 7 8 9 10
                .Select(int.Parse)                                               //10 5 5 99 3 4 2 5 1 1 4
                .ToArray();
            

            for (int i = 0; i < array.Length; i++)
            {
                int curentNumber = array[i];
                int sumLeft = 0;
                int sumRightt = 0;
                for (int k = i+1; k < array.Length; k++)
                    {
                        sumLeft += array[k];
                    }
                    for (int l = 0; l < i; l++)
                    {
                        sumRightt += array[l];
                    }
                    if (sumRightt == sumLeft)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                
            }

            Console.WriteLine("no");
        }
    }
}
