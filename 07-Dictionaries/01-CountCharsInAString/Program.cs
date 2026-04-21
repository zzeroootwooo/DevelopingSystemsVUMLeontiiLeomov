var counts = new Dictionary<char, int>();
foreach (var ch in Console.ReadLine()!)
{
    if (ch == ' ') continue;
    counts[ch] = counts.GetValueOrDefault(ch) + 1;
}
foreach (var kv in counts)
    Console.WriteLine($"{kv.Key} -> {kv.Value}");
