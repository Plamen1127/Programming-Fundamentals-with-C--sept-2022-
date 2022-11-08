using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtycomand = int.Parse(Console.ReadLine());
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < qtycomand; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Length == 3)
                {
                    string register = command[0];
                    string userName = command[1];
                    string licensePlateNumber = command[2];

                    if (!cars.ContainsKey(userName))
                    {
                        cars.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else
                {
                    string register = command[0];
                    string userName = command[1];

                    if (cars.ContainsKey(userName))
                    {
                        cars.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }

        }
    }
}
