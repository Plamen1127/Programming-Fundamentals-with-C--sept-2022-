using System;
using System.Linq;
using System.Text;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(message);

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] comandIfo = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandName = comandIfo[0];

                if (commandName == "InsertSpace")
                {
                    int index = int.Parse(comandIfo[1]);
                    //message = message.Insert(index, " ");
                    sb.Insert(index, " ");
                    Console.WriteLine(sb);
                }
                else if (commandName == "Reverse")
                {
                    string substring = comandIfo[1];
                    //int startIndex = message.IndexOf(substring);
                    int startIndex = sb.ToString().IndexOf(substring);

                    if (startIndex! != -1)
                    {
                        //message = message.Remove(startIndex, substring.Length);
                       sb.Remove(startIndex, substring.Length);
                        sb.Append(string.Join("", substring.Reverse()));
                        Console.WriteLine(sb);
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

                    sb.Replace(substring, replacement);
                    Console.WriteLine(sb);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {sb}");
        }
    }
}

