using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TakeOrSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<string> notNumbers = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            StringBuilder result = new StringBuilder();
            int indexForSkip = 0;


            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    numbers.Add(int.Parse(message[i].ToString()));
                }
                else
                {
                    notNumbers.Add(message[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(notNumbers);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                result.Append(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }   
    }
}
