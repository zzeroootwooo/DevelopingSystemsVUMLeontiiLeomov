int n = int.Parse(Console.ReadLine()!);
var guests = new List<string>();
for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine()!;
    if (line.EndsWith(" is going!"))
    {
        string name = line[..^10];
        if (guests.Contains(name)) Console.WriteLine($"{name} is already in the list!");
        else guests.Add(name);
    }
    else
    {
        string name = line[..^14];
        if (!guests.Contains(name)) Console.WriteLine($"{name} is not in the list!");
        else guests.Remove(name);
    }
}
foreach (var g in guests) Console.WriteLine(g);
