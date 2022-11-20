using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furniture>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)(.\d+)?$";
            List<string> furniture = new List<string>();

            Regex regex = new Regex(pattern);

            string input;
            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string furnitureName = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                    furniture.Add(furnitureName);
                }

            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
