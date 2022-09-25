using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;

            for (int i = username.Length-1; i >= 0; i--)
            {
                char curentChar = username[i];
                pass += curentChar;
            }
            string inputPass = Console.ReadLine();
            int counter = 1;
            while ( inputPass != pass)
            {
                
                Console.WriteLine($"Incorrect password. Try again.");
                inputPass = Console.ReadLine();
                counter += 1;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
