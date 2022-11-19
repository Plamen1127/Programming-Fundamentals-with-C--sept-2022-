using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string dates = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(dates);

            foreach (Match data in matchCollection)
            {
                var day = data.Groups["day"].Value;
                var month = data.Groups["month"].Value;
                var year = data.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
