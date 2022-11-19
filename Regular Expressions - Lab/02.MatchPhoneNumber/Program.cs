using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string telefonNumbers = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection numPhoneCollection = regex.Matches(telefonNumbers);

            //foreach (Match item in numFoneCollection)
            //{
            //    Console.Write(item + ", ");
            //}

            string[] result = numPhoneCollection.Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
