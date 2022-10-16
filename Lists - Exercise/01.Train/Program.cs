using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacityOfAWagon = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split();

                if (inputParams[0] == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    wagons.Add(value);
                }
                else
                {
                    int value = int.Parse(inputParams[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int sumPassengers = value + wagons[i];
                        if (sumPassengers <= maxCapacityOfAWagon)
                        {
                            wagons.Insert(i, sumPassengers);
                            wagons.RemoveAt(i + 1);
                            break;
                        }

                    }
                }
                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
