using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] comandA = comand.Split();

                if (comandA[0] == "Add")
                {
                    int addIndex = int.Parse(comandA[1]);
                    numbers.Add(addIndex);
                }
                else if (comandA[0] == "Insert")
                {
                    int value = int.Parse(comandA[1]);
                    int index = int.Parse(comandA[2]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, value);
                    }

                }
                else if (comandA[0] == "Remove")
                {
                    int removeIndex = int.Parse(comandA[1]);

                    if (IsIndexInvalid(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(removeIndex);
                    }
                   
                }
                else if (comandA[0] == "Shift")
                {
                    string direction = comandA[1];
                    int count = int.Parse(comandA[2]);

                    if (direction == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else
                    {
                        ShiftListRight(numbers, count);
                    }
                }
                comand = Console.ReadLine();
                
            }
            Console.WriteLine(String.Join(' ', numbers));
            
        }
        static bool IsIndexInvalid(List<int> numbers, int index)

                  => index < 0 || index >= numbers.Count;

        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }

        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
