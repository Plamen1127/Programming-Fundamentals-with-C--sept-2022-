using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] inputParams = input.Split();

                if( inputParams[0] == "Delete")
                {
                    int value = int.Parse(inputParams[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if ( numbers[i]== value)
                        {
                            numbers.Remove(value);
                        }
                    }
                }
                else if ( inputParams[0] == "Insert")
                {
                    int element = int.Parse(inputParams[1]);
                    int value = int.Parse(inputParams[2]);
                    numbers.Insert(value, element);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
