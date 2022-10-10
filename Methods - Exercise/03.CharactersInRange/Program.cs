using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());


            PrintAllCharactersBetweenCharacters(firstChar, secondChar);
            
        }

        static void PrintAllCharactersBetweenCharacters(char firstChar, char secondChar)
        {

            int resul = firstChar.CompareTo(secondChar);
            if ( resul < 0)
            {
                for (int i = firstChar+1; i <= secondChar-1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = secondChar + 1; i <= firstChar - 1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
