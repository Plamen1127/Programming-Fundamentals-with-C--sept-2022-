using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            

            foreach (var currentUser in users)
            {
                ChekUserNamesIsValid(currentUser);
            }
        }
        static void ChekUserNamesIsValid( string currentUser)
        {
            string valisUsers = string.Empty;
            for (int i = 0; i < currentUser.Length; i++)
            {
                if (currentUser.Length < 3 || currentUser.Length > 16)
                {
                    break;
                }
                char currentChar = currentUser[i];
                if (!char.IsDigit(currentChar) && !char.IsLetter(currentChar) && currentChar != '-' && currentChar != '_')
                {
                    break;
                }
                else
                {
                    valisUsers += currentChar;
                }
            }
            if (valisUsers == currentUser)
            {
                Console.WriteLine(valisUsers);
            }
        }
    }
    
}
