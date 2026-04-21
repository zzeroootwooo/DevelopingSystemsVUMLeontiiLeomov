int n = int.Parse(Console.ReadLine()!);
var seen = new LinkedList<string>();
var set = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine()!;
    if (set.Add(name)) seen.AddLast(name);
}
foreach (var name in seen) Console.WriteLine(name);
