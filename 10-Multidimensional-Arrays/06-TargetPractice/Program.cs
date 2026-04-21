var nm = Console.ReadLine()!.Split();
int N = int.Parse(nm[0]), M = int.Parse(nm[1]);
string snake = Console.ReadLine()!;
var shot = Console.ReadLine()!.Split();
int sr = int.Parse(shot[0]), sc = int.Parse(shot[1]), radius = int.Parse(shot[2]);

var matrix = new char[N, M];
int si = 0;
for (int r = N - 1; r >= 0; r--)
{
    if ((N - 1 - r) % 2 == 0)
        for (int c = M - 1; c >= 0; c--) { matrix[r, c] = snake[si % snake.Length]; si++; }
    else
        for (int c = 0; c < M; c++) { matrix[r, c] = snake[si % snake.Length]; si++; }
}

for (int r = 0; r < N; r++)
    for (int c = 0; c < M; c++)
    {
        double dist = Math.Sqrt(Math.Pow(r - sr, 2) + Math.Pow(c - sc, 2));
        if (dist <= radius) matrix[r, c] = ' ';
    }

for (int c = 0; c < M; c++)
    for (int r = N - 2; r >= 0; r--)
        if (matrix[r, c] != ' ')
        {
            int nr = r + 1;
            while (nr < N && matrix[nr, c] == ' ') nr++;
            if (nr < N && nr != r + 1) { matrix[nr - 1, c] = ' '; matrix[nr - 1 > r ? nr - 1 : r, c] = ' '; }
            if (matrix[r + 1, c] == ' ')
            {
                int drop = r + 1;
                while (drop < N && matrix[drop, c] == ' ') drop++;
                matrix[drop > N - 1 ? N - 1 : drop, c] = ' ';
                if (drop <= N - 1) { matrix[drop, c] = matrix[r, c]; matrix[r, c] = ' '; }
            }
        }

// gravity: drop chars down
for (int c = 0; c < M; c++)
    for (int r = N - 2; r >= 0; r--)
        if (matrix[r, c] != ' ' && matrix[r + 1, c] == ' ')
        {
            int nr = r + 1;
            while (nr < N - 1 && matrix[nr + 1, c] == ' ') nr++;
            matrix[nr, c] = matrix[r, c];
            matrix[r, c] = ' ';
        }

for (int r = 0; r < N; r++)
{
    var sb = new System.Text.StringBuilder();
    for (int c = 0; c < M; c++) sb.Append(matrix[r, c]);
    Console.WriteLine(sb);
}
