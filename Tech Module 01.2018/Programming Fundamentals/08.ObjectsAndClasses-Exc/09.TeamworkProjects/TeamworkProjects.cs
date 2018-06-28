using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamRegistration = Console.ReadLine().Split('-');
                string teamCreator = teamRegistration[0];
                string teamName = teamRegistration[1];
                CreateATeam(teams, teamCreator, teamName);
            }

            string memberRegistration = Console.ReadLine();

            while (memberRegistration != "end of assignment")
            {
                string[] memberInfo = memberRegistration
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string member = memberInfo[0];
                string teamName = memberInfo[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (teams.Any(x => x.Members.Contains(member) || x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }

                else
                {
                    foreach (var team in teams)
                    {
                        if (team.Name == teamName)
                        {
                            team.Members.Add(member);
                        }
                    }
                }

                memberRegistration = Console.ReadLine();
            }

            List<Team> validTeams = new List<Team>();
            List<Team> teamsToDisband = new List<Team>();

            foreach (var team in teams.Where(x => x.Members.Count > 0))
            {
                validTeams.Add(team);
            }
            foreach (var team in teams.Where(x => x.Members.Count == 0))
            {
                teamsToDisband.Add(team);
            }

            foreach (var team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamsToDisband.OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }

        static void CreateATeam(List<Team> teams, string teamCreator, string teamName)
        {
            if (teams.Any(x => x.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (teams.Any(x => x.Creator == teamCreator))
            {
                Console.WriteLine($"{teamCreator} cannot create another team!");
            }
            else
            {
                Team newTeam = new Team();
                newTeam.Name = teamName;
                newTeam.Creator = teamCreator;
                List<string> members = new List<string>();
                newTeam.Members = members;
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
            }
        }
    }

    class Team
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }
    }
}
