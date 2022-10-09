using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;

                case "string":
                    string firstString = Console.ReadLine();
                    string secuondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secuondString));
                    break;
            }


        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static char GetMax(char first, char secund)
        {
            if (first > secund)
            {
                return first;
            }

            return secund;
        }

        static string GetMax(string first, string secund)
        {
            int resul = first.CompareTo(secund);
            if (resul > 0)
            {
                return first;
            }

            return secund;
        }




    }
}
