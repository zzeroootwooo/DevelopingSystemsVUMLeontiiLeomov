string rotLine = Console.ReadLine()!;
int degrees = int.Parse(rotLine[7..^1]);
var lines = new List<string>();
string? line;
while ((line = Console.ReadLine()) != "END") lines.Add(line!);

int maxLen = lines.Max(l => l.Length);
var matrix = new char[lines.Count, maxLen];
for (int r = 0; r < lines.Count; r++)
    for (int c = 0; c < maxLen; c++)
        matrix[r, c] = c < lines[r].Length ? lines[r][c] : ' ';

int times = (degrees / 90) % 4;
for (int t = 0; t < times; t++) matrix = Rotate90(matrix);

int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
for (int r = 0; r < rows; r++)
{
    var sb = new System.Text.StringBuilder();
    for (int c = 0; c < cols; c++) sb.Append(matrix[r, c]);
    Console.WriteLine(sb.ToString().TrimEnd());
}

char[,] Rotate90(char[,] m)
{
    int r = m.GetLength(0), c = m.GetLength(1);
    var res = new char[c, r];
    for (int i = 0; i < r; i++)
        for (int j = 0; j < c; j++)
            res[j, r - 1 - i] = m[i, j];
    return res;
}
