int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
var tops = new List<int>();
for (int i = 0; i < arr.Length; i++)
{
    bool top = true;
    for (int j = i + 1; j < arr.Length; j++)
        if (arr[j] >= arr[i]) { top = false; break; }
    if (top) tops.Add(arr[i]);
}
Console.WriteLine(string.Join(" ", tops));
