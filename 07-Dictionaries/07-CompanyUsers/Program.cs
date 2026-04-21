var companies = new Dictionary<string, List<string>>();
string? line;
while ((line = Console.ReadLine()) != "End")
{
    var p = line!.Split(" -> ");
    string company = p[0], id = p[1];
    if (!companies.ContainsKey(company)) companies[company] = new List<string>();
    if (!companies[company].Contains(id)) companies[company].Add(id);
}
foreach (var kv in companies)
{
    Console.WriteLine(kv.Key);
    foreach (var id in kv.Value) Console.WriteLine($"-- {id}");
}
