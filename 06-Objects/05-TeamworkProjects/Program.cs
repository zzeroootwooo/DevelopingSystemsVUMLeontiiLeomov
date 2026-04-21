int n = int.Parse(Console.ReadLine()!);
var teams = new Dictionary<string, string>();           // teamName -> creator
var members = new Dictionary<string, List<string>>();  // teamName -> members
var userTeam = new Dictionary<string, string>();        // user -> teamName they created or joined

for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine()!;
    var parts = line.Split('-');
    var user = parts[0];
    var teamName = parts[1];
    if (teams.ContainsKey(teamName)) { Console.WriteLine($"Team {teamName} was already created!"); continue; }
    if (userTeam.ContainsKey(user)) { Console.WriteLine($"{user} cannot create another team!"); continue; }
    teams[teamName] = user;
    members[teamName] = new List<string>();
    userTeam[user] = teamName;
    Console.WriteLine($"Team {teamName} has been created by {user}!");
}

string? cmd;
while ((cmd = Console.ReadLine()) != "end of assignment")
{
    var parts = cmd!.Split("->");
    var user = parts[0];
    var teamName = parts[1];
    if (!teams.ContainsKey(teamName)) { Console.WriteLine($"Team {teamName} does not exist!"); continue; }
    if (userTeam.ContainsKey(user)) { Console.WriteLine($"Member {user} cannot join team {teamName}!"); continue; }
    members[teamName].Add(user);
    userTeam[user] = teamName;
}

var validTeams = teams.Where(t => members[t.Key].Count > 0)
    .OrderByDescending(t => members[t.Key].Count).ThenBy(t => t.Key);
foreach (var t in validTeams)
{
    Console.WriteLine($"{t.Key}");
    Console.WriteLine($"- {t.Value}");
    foreach (var m in members[t.Key].OrderBy(m => m))
        Console.WriteLine($"-- {m}");
}

var disbanded = teams.Where(t => members[t.Key].Count == 0).OrderBy(t => t.Key);
Console.WriteLine("Teams to disband:");
foreach (var t in disbanded) Console.WriteLine(t.Key);
