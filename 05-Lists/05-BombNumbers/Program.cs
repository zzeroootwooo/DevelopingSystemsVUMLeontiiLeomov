var seq = Console.ReadLine()!.Split().Select(int.Parse).ToList();
string[] bp = Console.ReadLine()!.Split();
int bomb = int.Parse(bp[0]), power = int.Parse(bp[1]);
int i = 0;
while (i < seq.Count)
{
    if (seq[i] == bomb)
    {
        int start = Math.Max(0, i - power);
        int end = Math.Min(seq.Count - 1, i + power);
        seq.RemoveRange(start, end - start + 1);
        i = start;
    }
    else i++;
}
Console.WriteLine(seq.Sum());
