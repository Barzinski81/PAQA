namespace _03.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teamList = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] team = Console.ReadLine().Split("-");

                string creator = team[0];
                string teamName = team[1];

                if (teamList.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (teamList.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team currentTeam = new Team(teamName, creator);
                    teamList.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {

                string[] inputSplit = input.Split("->");
                string member = inputSplit[0];
                string teamName = inputSplit[1];

                if (!teamList.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }


                else if (teamList.Any(t => t.Creator == member)
                        || teamList.Any(t => t.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }

                else
                {
                    Team team = teamList.First(t => t.Name == teamName);

                    team.Members.Add(member);
                }

                input = Console.ReadLine();
            }

            List<Team> teamsWithMembers = teamList.Where(t => t.Members.Count > 0)
                                                      .OrderByDescending(t => t.Members.Count)
                                                      .ThenBy(t => t.Name)
                                                      .ToList();

            List<Team> disbandedTeams = teamList.Where(t => t.Members.Count == 0)
                                                    .OrderBy(t => t.Name)
                                                    .ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var item in team.Members.OrderBy(i => i))
                {
                    Console.WriteLine($"-- {item}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }



        }
    }
}
