var nm = Console.ReadLine()!.Split();
int N = int.Parse(nm[0]), M = int.Parse(nm[1]);
var grid = new char[N][];
int pr = 0, pc = 0;
for (int r = 0; r < N; r++)
{
    grid[r] = Console.ReadLine()!.ToCharArray();
    for (int c = 0; c < M; c++)
        if (grid[r][c] == 'P') { pr = r; pc = c; grid[r][c] = '.'; }
}
string moves = Console.ReadLine()!;
string outcome = "";
int finalR = pr, finalC = pc;

foreach (char move in moves)
{
    int nr = pr, nc = pc;
    if (move == 'U') nr--;
    else if (move == 'D') nr++;
    else if (move == 'L') nc--;
    else nc++;

    if (nr < 0 || nr >= N || nc < 0 || nc >= M)
    {
        outcome = $"won: {pr} {pc}";
        SpreadBunnies();
        break;
    }
    if (grid[nr][nc] == 'B')
    {
        pr = nr; pc = nc;
        outcome = $"dead: {pr} {pc}";
        SpreadBunnies();
        break;
    }
    pr = nr; pc = nc;
    SpreadBunnies();
    if (grid[pr][pc] == 'B')
    {
        outcome = $"dead: {pr} {pc}";
        break;
    }
}

if (outcome == "") outcome = $"won: {pr} {pc}";

for (int r = 0; r < N; r++) Console.WriteLine(new string(grid[r]));
Console.WriteLine(outcome);

void SpreadBunnies()
{
    var newBunnies = new List<(int r, int c)>();
    for (int r = 0; r < N; r++)
        for (int c = 0; c < M; c++)
            if (grid[r][c] == 'B')
            {
                int[] dr = { -1, 1, 0, 0 }, dc = { 0, 0, -1, 1 };
                for (int d = 0; d < 4; d++)
                {
                    int nr2 = r + dr[d], nc2 = c + dc[d];
                    if (nr2 >= 0 && nr2 < N && nc2 >= 0 && nc2 < M && grid[nr2][nc2] == '.')
                        newBunnies.Add((nr2, nc2));
                }
            }
    foreach (var (r, c) in newBunnies) grid[r][c] = 'B';
}
