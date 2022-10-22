using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            double leftPlayer = 0;
            double rightPlayer = 0;

            for (int i = 0; i < time.Length/2; i++)
            {
                leftPlayer += time[i];
                rightPlayer += time[time.Length-1-i];

                if(time[i] == 0)
                {
                    leftPlayer *= 0.8;
                }

                if (time[time.Length - 1 - i] == 0)
                {
                    rightPlayer *= 0.8;
                }
            }

            if (leftPlayer < rightPlayer)
            {
                Console.WriteLine($"The winner is left with total time: {leftPlayer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightPlayer}");
            }
        }
    }
}
