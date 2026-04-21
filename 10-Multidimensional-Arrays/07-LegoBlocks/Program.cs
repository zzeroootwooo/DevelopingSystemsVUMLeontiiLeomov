int n = int.Parse(Console.ReadLine()!);
var first = new List<int[]>();
var second = new List<int[]>();
for (int i = 0; i < n; i++)
    first.Add(Console.ReadLine()!.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
for (int i = 0; i < n; i++)
    second.Add(Console.ReadLine()!.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
second.Reverse();

bool fits = true;
int? width = null;
for (int i = 0; i < n; i++)
{
    int len = first[i].Length + second[i].Length;
    if (width == null) width = len;
    else if (width != len) { fits = false; break; }
}

if (fits)
{
    for (int i = 0; i < n; i++)
    {
        var row = first[i].Concat(second[i]).ToArray();
        Console.WriteLine($"[{string.Join(", ", row)}]");
    }
}
else
{
    int total = first.Sum(r => r.Length) + second.Sum(r => r.Length);
    Console.WriteLine($"The total number of cells is: {total}");
}
