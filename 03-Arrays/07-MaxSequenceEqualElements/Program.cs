int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int bestStart = 0, bestLen = 1, curStart = 0, curLen = 1;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i - 1]) curLen++;
    else { curStart = i; curLen = 1; }
    if (curLen > bestLen) { bestLen = curLen; bestStart = curStart; }
}
Console.WriteLine(string.Join(" ", arr[bestStart..(bestStart + bestLen)]));
