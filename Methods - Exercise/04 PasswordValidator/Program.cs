using System;

namespace _04_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();


            ChecksHowManyCharactersThereAre(inputPass);

        }

        static void ChecksHowManyCharactersThereAre(string inputPass)
        { 
            int counterChar = 0;

            for (int i = 0; i <= inputPass.Length-1; i++)
            {
                counterChar++;
            }
            if(counterChar <= 6 || counterChar >= 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }

    }
}
