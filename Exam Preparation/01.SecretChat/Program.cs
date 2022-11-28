using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] comandIfo = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandName = comandIfo[0];

                if (commandName == "InsertSpace")
                {
                    int index = int.Parse(comandIfo[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (commandName == "Reverse")
                {
                    string substring = comandIfo[1];
                    int startIndex = message.IndexOf(substring);

                    if (startIndex! != -1)
                    {
                        message = message.Remove(startIndex, substring.Length);
                        message += string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "ChangeAll")
                {
                    string substring = comandIfo[1];
                    string replacement = comandIfo[2];

                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
