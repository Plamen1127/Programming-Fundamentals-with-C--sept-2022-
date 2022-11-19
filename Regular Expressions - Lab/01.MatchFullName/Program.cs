using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchedNames = regex.Matches(names);


            foreach (Match item in matchedNames)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
