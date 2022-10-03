using System;
using System.Linq;

namespace _05.Top_ntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)                                               //0 1 2 3
                .ToArray();                                                      //1 4 3 2

            for (int i = 0; i < array.Length; i++)
            {
                int curentNumber = array[i];
                bool bigInteger = true;
                for (int k = i+1; k < array.Length; k++)
                {
                    int nextNumber = array[k];
                    if (nextNumber>= curentNumber)
                    {
                        bigInteger = false;
                        break;
                    }
                }
                if (bigInteger)
                {
                    Console.Write(curentNumber + " ");
                }
            }
        }
    }
}
