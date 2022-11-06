using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(n);

            while (n > 0)
            {
                string[] data = Console.ReadLine()
                                .Split("-")
                                .ToArray();

                string creator = data[0];
                string teamName = data[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(teamName, creator));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

                n--;
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {

                string[] data = input
                                .Split("->")
                                .ToArray();

                string memberName = data[0];
                string teamName = data[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.Members.Contains(memberName)) ||
                         teams.Any(x => x.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    Team currentTeam = teams.Where(x => x.Name == teamName).FirstOrDefault();
                    currentTeam.Members.Add(memberName);
                }

                input = Console.ReadLine();
            }

            foreach (var team in teams.Where(x => x.Members.Count > 0)
                                      .OrderByDescending(x => x.Members.Count)
                                      .ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.Where(x => x.Members.Count == 0)
                                      .OrderBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }

}