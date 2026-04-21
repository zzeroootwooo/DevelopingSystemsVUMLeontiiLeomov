string text = Console.ReadLine()!;
var counts = new SortedDictionary<char, int>();
foreach (var c in text) counts[c] = counts.GetValueOrDefault(c) + 1;
foreach (var kv in counts)
    Console.WriteLine($"{kv.Key}: {kv.Value} time/s");
