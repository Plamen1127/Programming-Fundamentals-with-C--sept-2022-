using System;
using System.Collections.Generic;

namespace _03.HeroesOfCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> herosHP = new Dictionary<string, int>();
            Dictionary<string, int> herosMP = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] herosArguments = Console.ReadLine().Split(" ");
                string name = herosArguments[0];
                int healtPoints = int.Parse(herosArguments[1]);
                int manaPoints = int.Parse(herosArguments[2]);

                herosHP[name] = healtPoints;
                herosMP[name] = manaPoints;
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgument = input.Split(" - ");
                string type = cmdArgument[0];
                string nameHeros = cmdArgument[1];

                if (type == "CastSpell")
                {
                    int neededManaPoints = int.Parse(cmdArgument[2]);
                    string spellName = cmdArgument[3];

                    if (herosMP[nameHeros] >= neededManaPoints)
                    {
                        herosMP[nameHeros] -= neededManaPoints;
                        Console.WriteLine($"{nameHeros} has successfully cast {spellName} and now has {herosMP[nameHeros]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameHeros} does not have enough MP to cast { spellName}!");
                    }
                }

                else if (type == "TakeDamage")
                {
                    int damageHalt = int.Parse(cmdArgument[2]);
                    string attacker = cmdArgument[3];

                    if (herosHP[nameHeros] > damageHalt)
                    {
                        herosHP[nameHeros] -= damageHalt;
                        Console.WriteLine($"{nameHeros} was hit for {damageHalt} HP by {attacker} and now has {herosHP[nameHeros]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameHeros} has been killed by {attacker}!");
                        herosHP.Remove(nameHeros);
                        herosMP.Remove(nameHeros);
                    }
                }

                else if (type == "Recharge")
                {
                    int amount = int.Parse(cmdArgument[2]);

                    if (herosMP[nameHeros] + amount > 200)
                    {
                        amount = 200 - herosMP[nameHeros];
                    }

                    herosMP[nameHeros] += amount;
                    Console.WriteLine($"{nameHeros} recharged for {amount} MP!");
                }
                else if (type == "Heal")
                {
                    int amount = int.Parse(cmdArgument[2]);

                    if (amount + herosHP[nameHeros] > 100)
                    {
                        amount = 100 - herosHP[nameHeros];
                    }

                    herosHP[nameHeros] += amount;
                    Console.WriteLine($"{nameHeros} healed for {amount} HP!");
                }
                input = Console.ReadLine();
            }

            foreach (var item in herosHP)
            {
                string nameHeros = item.Key;
                int hP = item.Value;
                int mP = herosMP[nameHeros];

                Console.WriteLine(nameHeros);
                Console.WriteLine($"  HP: {hP}");
                Console.WriteLine($"  MP: {mP}");
            }
        }
    }
}
