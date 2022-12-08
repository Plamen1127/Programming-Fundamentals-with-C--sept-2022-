using System;
using System.Text.RegularExpressions;

namespace _4.SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string cryptedMessage = Console.ReadLine();

            while (cryptedMessage != "end")
            {
                string message = Decrypt(cryptedMessage, key);
                Match match = Regex.Match(message, @"@(?<name>[A-Za-z]+)[^-@!:>]+!(?<behavior>G)!");

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;

                    Console.WriteLine(name);
                }

                cryptedMessage = Console.ReadLine();
            }

        }

        static string Decrypt(string cryptedMessage, int key)
        {
            string message = string.Empty;

            for (int i = 0; i < cryptedMessage.Length; i++)
            {
                char crnChar = (char)(cryptedMessage[i] - key);
                message += crnChar;
            }

            return message;
        }
    }
}