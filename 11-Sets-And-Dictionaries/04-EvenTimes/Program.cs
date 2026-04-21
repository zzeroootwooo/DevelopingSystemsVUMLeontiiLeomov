int n = int.Parse(Console.ReadLine()!);
var counts = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine()!);
    counts[x] = counts.GetValueOrDefault(x) + 1;
}
Console.WriteLine(counts.First(kv => kv.Value % 2 == 0).Key);
