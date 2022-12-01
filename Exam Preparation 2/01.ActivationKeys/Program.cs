using System;
using System.Text;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandInfo = command
                    .Split(">>>");

                string action = commandInfo[0];

                if (action == "Contains")
                {
                    string substring = commandInfo[1];
                    if (activationKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string flipType = commandInfo[1];
                    int startIndex = int.Parse(commandInfo[2]);
                    int endIndex = int.Parse(commandInfo[3]);

                    string substring = activationKey.ToString().Substring(startIndex, endIndex - startIndex);

                    if (flipType == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else
                    {
                        substring = substring.ToLower();
                    }

                    activationKey.Remove(startIndex, endIndex - startIndex);
                    activationKey.Insert(startIndex, substring);

                    Console.WriteLine(activationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);
                    activationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(activationKey);

                }
            }

            Console.WriteLine(activationKey);
        }
    }
}
