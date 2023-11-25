//1. Team creation and keeping -> can't have two teams with the same creator + cant create team with existing name
int countTeams = int.Parse(Console.ReadLine());

Dictionary<string, Team> teams = new Dictionary<string, Team>(); //{key -> Team name} -> {value -> Team(object)}

//TODO: find out where to keep the created teams
for (int i = 1; i <= countTeams; i++)
{
    string[] teamInfo = Console.ReadLine().Split("-");
    string teamCreator = teamInfo[0];
    string teamName = teamInfo[1];

    if (teams.ContainsKey(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
    }
    else
    {
        Team team = new Team(teamName, teamCreator);
        Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
        //TODO: keep the new team somewhere (done)
        teams.Add(teamName, team); // team name we've read + our object "team"
    }
}

//2. Team Modification

string input;
while ((input = Console.ReadLine()) != "end of assignment")
{
    string[] command = input.Split("->");

    string memberJoining = command[0];
    string teamToJoin = command[1];

    if (!teams.ContainsKey(teamToJoin))
    {
        Console.WriteLine($"Team {teamToJoin} does not exist!");
    }  
    else
    {
        if (teamToJoin.Contains(memberJoining))
        {
            Console.WriteLine($"Member {memberJoining} cannot join team {teamToJoin}!");
        }
        else
        {
            //move memberToMove -> into teamToJoin
            teams[teamToJoin].Members.Add(memberJoining); // add memberJoining to the Member property which is actually a List
        }       
    }
}

//3. Printer

//1. teams without members
//2. teams with members

//sort only the teams with members
foreach (var team in teams.Where(t => t.Value.Members.Count > 0) // we filter and leave only teams that have members
                          .OrderByDescending(t => t.Value.Members.Count) // sort by descending number of people in a team overall
                           .ThenBy(t => t.Key)) // sort by ascending team name
{
    // sorted Dictionary only with teams that have members
    // team -> zapis or technika
    // team.Key -> ime na otbora
    // team,Vakye -> obektut Team

    Console.WriteLine(team.Key);
    Console.WriteLine("- " + team.Value.Creator);

    foreach (string member in team.Value.Members.OrderBy(m => m))
    {
        Console.WriteLine("-- " + member);
    }


}

//2. print teams with no members
Console.WriteLine("Teams to disband: ");
foreach (var team in teams.Where(t => t.Value.Members.Count == 0))
{
    Console.WriteLine(team.Key);
}




