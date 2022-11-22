using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^\%\|\$\.]*?<(?<product>[\w]+)>[^\%\|\$\.]*?\|(?<quantity>\d+)\|[^\%\|\$\.]*?(?<price>\d([.\d]+)?)\$[^\%\|\$\.]*?$";
            Regex regex = new Regex(pattern);
            string command;
            double totalPrice = 0;

            while ((command = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(command);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double currPrice = price * quantity;
                    totalPrice += currPrice;

                    Console.WriteLine($"{customer}: {product} - {currPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}
