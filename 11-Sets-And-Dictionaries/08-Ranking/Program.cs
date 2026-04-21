var contests = new Dictionary<string, string>();  // contest -> password
string? line;
while ((line = Console.ReadLine()) != "end of contests")
{
    var p = line!.Split(':');
    contests[p[0]] = p[1];
}

var scores = new Dictionary<string, Dictionary<string, int>>();  // user -> contest -> points
while ((line = Console.ReadLine()) != "end of submissions")
{
    var p = line!.Split("=>");
    string contest = p[0], pass = p[1], user = p[2], pts = p[3];
    if (!contests.TryGetValue(contest, out var correctPass) || correctPass != pass) continue;
    int points = int.Parse(pts);
    if (!scores.ContainsKey(user)) scores[user] = new Dictionary<string, int>();
    if (!scores[user].TryGetValue(contest, out int existing) || points > existing)
        scores[user][contest] = points;
}

var best = scores.OrderByDescending(kv => kv.Value.Values.Sum()).First();
Console.WriteLine($"Best candidate is {best.Key} with total {best.Value.Values.Sum()} points.");
Console.WriteLine("Ranking:");
foreach (var user in scores.OrderBy(kv => kv.Key))
{
    Console.WriteLine(user.Key);
    foreach (var contest in user.Value.OrderByDescending(kv => kv.Value))
        Console.WriteLine($"# {contest.Key} -> {contest.Value}");
}
