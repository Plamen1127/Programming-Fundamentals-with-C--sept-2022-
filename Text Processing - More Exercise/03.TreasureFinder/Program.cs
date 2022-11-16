using System;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;

            while ((command = Console.ReadLine()) != "find")
            {
                int factor = 0;
                string decrypted = string.Empty;
                string tresure = string.Empty;
                string coordinates = string.Empty;

                for (int i = 0; i < command.Length; i++)
                {
                    if (i % key.Length == 0 && i != 0)
                    {
                        factor += key.Length;
                    }

                    int currCh = command[i] - key[i - factor];
                    decrypted += (char)currCh;
                }

                int tresureStartIndex = decrypted.IndexOf('&') + 1;
                int coorStartIndex = decrypted.IndexOf('<') + 1;
                int tresureEndIndex = decrypted.LastIndexOf('&');
                int coorEndIndex = decrypted.LastIndexOf('>');

                for (int j = tresureStartIndex; j < tresureEndIndex; j++)
                {
                    tresure += decrypted[j];
                }
                for (int k = coorStartIndex; k < coorEndIndex; k++)
                {
                    coordinates += decrypted[k];
                }

                Console.WriteLine($"Found {tresure} at {coordinates}");

            }
        }
    }
}
