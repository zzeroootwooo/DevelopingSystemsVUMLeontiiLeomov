var rc = Console.ReadLine()!.Split();
int R = int.Parse(rc[0]), C = int.Parse(rc[1]);
var matrix = new int[R, C];
int val = 1;
for (int r = 0; r < R; r++)
    for (int c = 0; c < C; c++)
        matrix[r, c] = val++;

int n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < n; i++)
{
    var p = Console.ReadLine()!.Split();
    int idx = int.Parse(p[0]);
    string dir = p[1];
    int moves = (int)(long.Parse(p[2]) % (dir == "left" || dir == "right" ? C : R));
    if (dir == "left" || dir == "right")
    {
        int row = idx;
        var tmp = new int[C];
        for (int c = 0; c < C; c++) tmp[c] = matrix[row, c];
        if (dir == "right") moves = C - moves;
        for (int c = 0; c < C; c++) matrix[row, c] = tmp[(c + moves) % C];
    }
    else
    {
        int col = idx;
        var tmp = new int[R];
        for (int r = 0; r < R; r++) tmp[r] = matrix[r, col];
        if (dir == "down") moves = R - moves;
        for (int r = 0; r < R; r++) matrix[r, col] = tmp[(r + moves) % R];
    }
}

var orig = new int[R, C];
val = 1;
for (int r = 0; r < R; r++)
    for (int c = 0; c < C; c++)
        orig[r, c] = val++;

for (int r = 0; r < R; r++)
    for (int c = 0; c < C; c++)
    {
        int need = orig[r, c];
        if (matrix[r, c] == need) { Console.WriteLine("No swap required"); continue; }
        bool found = false;
        for (int r2 = 0; r2 < R && !found; r2++)
            for (int c2 = 0; c2 < C && !found; c2++)
                if (matrix[r2, c2] == need)
                {
                    Console.WriteLine($"Swap ({r}, {c}) with ({r2}, {c2})");
                    matrix[r2, c2] = matrix[r, c];
                    matrix[r, c] = need;
                    found = true;
                }
    }
