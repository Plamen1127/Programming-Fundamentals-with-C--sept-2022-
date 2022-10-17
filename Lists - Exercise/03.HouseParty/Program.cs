using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            List<string> guestlist = new List<string>();


            for (int i = 1; i <= qty; i++)
            {
                string comand = Console.ReadLine();
                string[] comandA = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = comandA[0];



                if (comandA.Length == 3)
                {
                    if (guestlist.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestlist.Add(name);
                    }
                }
                else if (comandA.Length == 4)
                {
                    if (!guestlist.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guestlist.Remove(name);
                    }
                }

            }



            foreach (string name in guestlist)
            {
                Console.WriteLine(name);
            }


        }
    }
}
