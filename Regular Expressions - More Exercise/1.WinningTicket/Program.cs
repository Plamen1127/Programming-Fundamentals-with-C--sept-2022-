using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Regex.Split(Console.ReadLine(), @" *,{1} *").ToList();

            foreach (var ticket in tickets)
            {
                CheckTicket(ticket);
            }
        }

        static void CheckTicket(string ticket)
        {
            string pattern = @"([@#$^])\1+";

            if (ticket.Length == 20)
            {
                MatchCollection matches = Regex.Matches(ticket, pattern);

                if (matches.Count == 1)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                }
                else
                {
                    PrintResult(matches, ticket);
                }
            }
            else
            {
                Console.WriteLine("invalid ticket");
            }
        }

        static void PrintResult(MatchCollection matches, string ticket)
        {
            if (matches.Count > 1)
            {
                string firstSequence = matches.OrderByDescending(x => x.Length).First().ToString();
                string secondSequence = matches.OrderByDescending(x => x.Length)
                                               .Select(x => x.ToString())
                                               .ToList()[1];

                if (firstSequence[0] == secondSequence[0] &&
                    secondSequence.Length >= 6 && secondSequence.Length <= 9)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {secondSequence.Length}{secondSequence[0]}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}