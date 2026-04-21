var vloggers = new Dictionary<string, HashSet<string>>();  // name -> followers
var following = new Dictionary<string, HashSet<string>>();  // name -> who they follow
var order = new List<string>();

string? line;
while ((line = Console.ReadLine()) != "Statistics")
{
    if (line!.EndsWith("joined The V-Logger"))
    {
        string name = line.Split()[0];
        if (!vloggers.ContainsKey(name))
        {
            vloggers[name] = new HashSet<string>();
            following[name] = new HashSet<string>();
            order.Add(name);
        }
    }
    else if (line.Contains(" followed "))
    {
        var p = line.Split(" followed ");
        string a = p[0], b = p[1];
        if (!vloggers.ContainsKey(a) || !vloggers.ContainsKey(b)) continue;
        if (a == b) continue;
        if (following[a].Contains(b)) continue;
        following[a].Add(b);
        vloggers[b].Add(a);
    }
}

Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
var sorted = vloggers.OrderByDescending(kv => kv.Value.Count).ThenBy(kv => following[kv.Key].Count).ToList();
int rank = 1;
foreach (var kv in sorted)
{
    Console.WriteLine($"{rank}. {kv.Key} : {kv.Value.Count} followers, {following[kv.Key].Count} following");
    if (rank == 1)
        foreach (var f in kv.Value.OrderBy(x => x)) Console.WriteLine($"* {f}");
    rank++;
}
