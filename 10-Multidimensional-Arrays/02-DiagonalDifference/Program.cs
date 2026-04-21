int n = int.Parse(Console.ReadLine()!);
var matrix = new int[n][];
for (int i = 0; i < n; i++)
    matrix[i] = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int primary = 0, secondary = 0;
for (int i = 0; i < n; i++)
{
    primary += matrix[i][i];
    secondary += matrix[i][n - 1 - i];
}
Console.WriteLine(Math.Abs(primary - secondary));
