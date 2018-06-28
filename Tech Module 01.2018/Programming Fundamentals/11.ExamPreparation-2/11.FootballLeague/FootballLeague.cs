using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11.FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);
            string[] fixtures = Console.ReadLine()
                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"(?<key>{key})(?<team>[A-Za-z]+)(\k<key>)";
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (fixtures[0] != "final")
            {
                Team team1 = new Team();
                Team team2 = new Team();
                var match1 = Regex.Match(fixtures[0], pattern);
                var match2 = Regex.Match(fixtures[1], pattern);

                team1.Name = match1.Groups["team"].Value.ToUpper();
                team1.Name = ReverseString(team1.Name);
                team2.Name = match2.Groups["team"].Value.ToUpper();
                team2.Name = ReverseString(team2.Name);
                CalculatePoints(fixtures, team1, team2);
                team1.Goals = long.Parse(fixtures[2]);
                team2.Goals = long.Parse(fixtures[3]);

                UpdateTableOfTeams(teams, team1);
                UpdateTableOfTeams(teams, team2);

                fixtures = Console.ReadLine()
                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            int count = 1;
            Console.WriteLine("League standings:");

            foreach (var team in teams.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value.Points}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in teams.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }

        static void UpdateTableOfTeams(Dictionary<string, Team> teams, Team team)
        {
            if (!teams.ContainsKey(team.Name))
            {
                teams.Add(team.Name, team);
            }
            else
            {
                teams[team.Name].Points += team.Points;
                teams[team.Name].Goals += team.Goals;
            }
        }

        static void CalculatePoints(string[] fixtures, Team team1, Team team2)
        {
            if (long.Parse(fixtures[2]) > long.Parse(fixtures[3]))
            {
                team1.Points = 3;
            }
            else if (long.Parse(fixtures[2]) == long.Parse(fixtures[3]))
            {
                team1.Points = 1;
                team2.Points = 1;
            }
            else
            {
                team2.Points = 3;
            }
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        class Team
        {
            public string Name { get; set; }
            public int Points { get; set; }
            public long Goals { get; set; }
        }
    }
}
