using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] company = input.Split(" -> ").ToArray();
                string nameCopany = company[0];
                string id = company[1];

                if (!companies.ContainsKey(nameCopany))
                {
                    companies.Add(nameCopany, new List<string>());
                }
                if (!companies[nameCopany].Contains(id))
                {
                    companies[nameCopany].Add(id);
                }
            }

            foreach (var curentCompany in companies)
            {
                Console.WriteLine(curentCompany.Key);
                Console.WriteLine($"-- {string.Join("\n-- ", curentCompany.Value)}");
            }
        }
    }
}
