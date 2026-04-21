var resources = new Dictionary<string, long>();
string? line;
while ((line = Console.ReadLine()) != "stop")
{
    string resource = line!;
    long qty = long.Parse(Console.ReadLine()!);
    resources[resource] = resources.GetValueOrDefault(resource) + qty;
}
foreach (var kv in resources)
    Console.WriteLine($"{kv.Key} – {kv.Value}");
