using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string result = ReturnNewString(@string, times);

             Console.WriteLine( result);
        }

        static string ReturnNewString( string @string, int times)           // по този начин става пак, но пълним паметта защото
                                                                            // създава фора създава всеки път стринг и го долепя.
                                                                            // а с StringBuilder и  .Append() само добавяме към стрингач
        {
            StringBuilder newString = new StringBuilder();                // string newString = string.Empty; 
            for (int i = 1; i <= times; i++)
            {
                for (int j = 1; j < @string.Length; j++)
                {
                    newString.Append(@string);                              //newString += @string[j];
                }
            }
            return newString.ToString();                                   //return newString;
        }
    }
}
