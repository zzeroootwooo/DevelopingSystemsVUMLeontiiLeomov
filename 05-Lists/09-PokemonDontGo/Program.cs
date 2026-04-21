var seq = Console.ReadLine()!.Split().Select(long.Parse).ToList();
long total = 0;
while (seq.Count > 0)
{
    int idx = int.Parse(Console.ReadLine()!);
    long removed;
    if (idx < 0)
    {
        removed = seq[0];
        seq[0] = seq[^1];
        seq.RemoveAt(seq.Count - 1);
    }
    else if (idx >= seq.Count)
    {
        removed = seq[^1];
        seq[^1] = seq[0];
        seq.RemoveAt(seq.Count - 1);
    }
    else
    {
        removed = seq[idx];
        seq.RemoveAt(idx);
    }
    total += removed;
    for (int i = 0; i < seq.Count; i++)
        seq[i] = seq[i] <= removed ? seq[i] + removed : seq[i] - removed;
}
Console.WriteLine(total);
