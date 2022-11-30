using System;
using System.Collections.Generic;

namespace _03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pieses = new Dictionary<string, string>();

            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                string[] piece = Console.ReadLine().Split("|");
                string piecName = piece[0];
                string compuseKay = $"{piece[1]}:{piece[2]}";

                if (!pieses.ContainsKey(piecName))
                {
                    pieses.Add(piecName, compuseKay);
                }
            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] comandInfo = command.Split("|");
                string action = comandInfo[0];
                string piecName = comandInfo[1];

                if (action == "Add")
                {

                    string compusKay = $"{comandInfo[2]}:{comandInfo[3]}";

                    if (!pieses.ContainsKey(piecName))
                    {
                        pieses.Add(piecName, compusKay);
                        Console.WriteLine($"{piecName} by {comandInfo[2]} in {comandInfo[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piecName} is already in the collection!");
                    }
                }

                else if (action == "Remove")
                {
                    if (pieses.ContainsKey(piecName))
                    {
                        pieses.Remove(piecName);
                        Console.WriteLine($"Successfully removed {piecName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piecName} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string newKay = comandInfo[2];
                    if (pieses.ContainsKey(piecName))
                    {
                        string[] value = pieses[piecName].Split(":");
                        value[1] = newKay;
                        pieses[piecName] = string.Join(":", value);
                        Console.WriteLine($"Changed the key of {piecName} to {newKay}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piecName} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in pieses)
            {
                string[] composerKay = piece.Value.Split(":");
                Console.WriteLine($"{piece.Key} -> Composer: {composerKay[0]}, Key: {composerKay[1]}");
            }
        }
    }
}
