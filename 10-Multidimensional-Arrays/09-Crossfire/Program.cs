var dims = Console.ReadLine()!.Split();
int R = int.Parse(dims[0]), C = int.Parse(dims[1]);
var matrix = new int[R, C];
var alive = new bool[R, C];
int val = 1;
for (int r = 0; r < R; r++)
    for (int c = 0; c < C; c++) { matrix[r, c] = val++; alive[r, c] = true; }

string? line;
while ((line = Console.ReadLine()) != "Nuke it from orbit")
{
    var p = line!.Split();
    int tr = int.Parse(p[0]), tc = int.Parse(p[1]), radius = int.Parse(p[2]);
    for (int dc = -radius; dc <= radius; dc++)
        if (tc + dc >= 0 && tc + dc < C) alive[tr, tc + dc] = false;
    for (int dr = -radius; dr <= radius; dr++)
        if (tr + dr >= 0 && tr + dr < R) alive[tr + dr, tc] = false;
}

for (int r = 0; r < R; r++)
{
    var cells = new List<int>();
    for (int c = 0; c < C; c++)
        if (alive[r, c]) cells.Add(matrix[r, c]);
    if (cells.Count > 0) Console.WriteLine(string.Join(" ", cells));
}
