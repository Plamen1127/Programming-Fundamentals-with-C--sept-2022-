using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> num2 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            List<int>  newList= new List<int>();
            List<int> result = new List<int>();
            int firstnum = 0;
            int secondnum = 0;

            int minList = Math.Min(num1.Count, num2.Count);

            for (int i = 0; i < minList; i++)
            {
                if (num1.Count > num2.Count)
                {
                    newList.Add(num1[i]);
                    newList.Add(num2[num2.Count-1-i]);
                    firstnum = num1[minList] ;
                    secondnum = num1[minList + 1];

                }
                else
                {
                    newList.Add(num1[i]);
                    newList.Add(num2[num2.Count - 1 - i]);
                    firstnum = num2[0];
                    secondnum = num2[1];
                }
            }
            int min = Math.Min(firstnum, secondnum);
            int max = Math.Max(firstnum, secondnum);

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] > min && newList[i] < max)
                {
                    result.Add(newList[i]);
                }
                
            }

            Console.WriteLine($"{firstnum}{secondnum}");
            Console.WriteLine(string.Join(" ", result.OrderBy(x => x)));


        }

    }
}
