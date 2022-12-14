using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxLength = 0;
            int lastIndex = -1;
            int[] len = new int[array.Length];
            int[] prev = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (array[k] < array[i] && len[k] + 1 > len[i])
                    {
                        len[i] = 1 + len[k];
                        prev[i] = k;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }

            }

            int[] LIS = new int[maxLength];
            int currentIndex = maxLength - 1;

            while (lastIndex != -1)
            {
                LIS[currentIndex] = array[lastIndex];
                currentIndex--;
                lastIndex = prev[lastIndex];
            }

            Console.WriteLine(string.Join(" ", LIS));
        }
    }
}