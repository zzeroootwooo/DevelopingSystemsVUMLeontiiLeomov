int len = int.Parse(Console.ReadLine()!);
int bestIdx = 1, bestSeqLen = -1, bestSeqStart = int.MaxValue, bestSum = -1;
int[] bestDNA = Array.Empty<int>();
int idx = 1;
string? line;
while ((line = Console.ReadLine()) != "Clone them!")
{
    int[] dna = line!.Split('!', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse).ToArray();
    int maxLen = 0, maxStart = 0, curLen = 0;
    for (int i = 0; i < dna.Length; i++)
    {
        if (dna[i] == 1) curLen++;
        else curLen = 0;
        if (curLen > maxLen) { maxLen = curLen; maxStart = i - curLen + 1; }
    }
    int sum = dna.Sum();
    bool better = bestSeqLen == -1
        || maxLen > bestSeqLen
        || (maxLen == bestSeqLen && maxStart < bestSeqStart)
        || (maxLen == bestSeqLen && maxStart == bestSeqStart && sum > bestSum);
    if (better) { bestIdx = idx; bestSeqLen = maxLen; bestSeqStart = maxStart; bestSum = sum; bestDNA = dna; }
    idx++;
}
Console.WriteLine($"Best DNA sample {bestIdx} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestDNA));
