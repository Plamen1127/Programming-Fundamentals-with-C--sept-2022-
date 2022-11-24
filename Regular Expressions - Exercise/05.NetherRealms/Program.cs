using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<health>[^\d\+\-\*\/\.]+)";
            string pattern2 = @"(?<damage>[-]?\d([.\d]+)?)";
            string patter3 = @"(?<action>[\*|\/]*)";

            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(pattern2);
            Regex regex3 = new Regex(patter3);

            string[] input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
            }

            string[] input1 = input
                .OrderBy(x => x)
                .ToArray();

            for (int i = 0; i < input1.Length; i++)
            {
                string currEl = input1[i];
                MatchCollection match = regex.Matches(currEl);
                MatchCollection match2 = regex2.Matches(currEl);
                MatchCollection match3 = regex3.Matches(currEl);

                var currHealth = new StringBuilder();
                List<double> currAttack = new List<double>();
                var currAction = new StringBuilder();

                foreach (Match item in match)
                {

                    string chealth = item.Groups["health"].Value;
                    currHealth.Append(chealth);

                }
                foreach (Match item in match2)
                {
                    string cattack = item.Groups["damage"].Value;
                    if (cattack != String.Empty)
                    {
                        currAttack.Add(double.Parse(cattack));
                    }
                }
                foreach (Match item in match3)
                {
                    string caction = item.Groups["action"].Value;
                    currAction.Append(caction);
                }

                int totalHp = TotalHealth(currHealth);
                double totalAtk = TotalAtack(currAttack, currAction);

                Console.WriteLine($"{currEl} - {totalHp} health, {totalAtk:f2} damage");
            }



        }

        private static int TotalHealth(StringBuilder currHealth)
        {
            int totalHp = 0;
            foreach (char hpCh in currHealth.ToString())
            {
                if (hpCh != 0 && hpCh != 1 && hpCh != 2 && hpCh != 3 && hpCh != 4 && hpCh != 5 && hpCh != 6 && hpCh != 7 && hpCh != 8 && hpCh != 9 && hpCh != '.' && hpCh != '+' && hpCh != '-' && hpCh != '*' && hpCh != '/' && hpCh != ' ')
                {
                    totalHp += hpCh;
                }

            }
            return totalHp;
        }

        private static double TotalAtack(List<double> currAttack, StringBuilder currAction)
        {
            double totalAtk = 0;
            foreach (var item in currAttack)
            {
                totalAtk += item;
            }

            foreach (var item in currAction.ToString())
            {
                if (item == '*')
                {
                    totalAtk *= 2;
                }
                else if (item == '/')
                {
                    totalAtk /= 2;
                }
            }
            return totalAtk;
        }
    }
}
