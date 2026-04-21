var nm = Console.ReadLine()!.Split();
int n = int.Parse(nm[0]), m = int.Parse(nm[1]);
var matrix = new int[n][];
for (int i = 0; i < n; i++)
    matrix[i] = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int maxSum = int.MinValue, maxR = 0, maxC = 0;
for (int r = 0; r <= n - 3; r++)
    for (int c = 0; c <= m - 3; c++)
    {
        int sum = 0;
        for (int dr = 0; dr < 3; dr++)
            for (int dc = 0; dc < 3; dc++)
                sum += matrix[r + dr][c + dc];
        if (sum > maxSum) { maxSum = sum; maxR = r; maxC = c; }
    }
Console.WriteLine($"Sum = {maxSum}");
for (int dr = 0; dr < 3; dr++)
    Console.WriteLine(string.Join(" ", Enumerable.Range(maxC, 3).Select(c => matrix[maxR + dr][c])));
