int n = int.Parse(Console.ReadLine()!);
var wardrobe = new Dictionary<string, Dictionary<string, int>>();
for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine()!;
    var p = line.Split(" -> ");
    string color = p[0];
    if (!wardrobe.ContainsKey(color)) wardrobe[color] = new Dictionary<string, int>();
    foreach (var item in p[1].Split(','))
        wardrobe[color][item] = wardrobe[color].GetValueOrDefault(item) + 1;
}
var search = Console.ReadLine()!.Split();
string searchColor = search[0], searchItem = search[1];
foreach (var kv in wardrobe)
{
    Console.WriteLine($"{kv.Key} clothes:");
    foreach (var item in kv.Value)
    {
        bool found = kv.Key == searchColor && item.Key == searchItem;
        Console.WriteLine($"* {item.Key} - {item.Value}{(found ? " (found!)" : "")}");
    }
}
