int n = int.Parse(Console.ReadLine()!);
var elements = new SortedSet<string>();
for (int i = 0; i < n; i++)
    foreach (var el in Console.ReadLine()!.Split()) elements.Add(el);
Console.WriteLine(string.Join(" ", elements));
