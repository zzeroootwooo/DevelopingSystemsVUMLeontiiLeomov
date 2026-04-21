var rc = Console.ReadLine()!.Split();
int rows = int.Parse(rc[0]), cols = int.Parse(rc[1]);
var matrix = new string[rows][];
for (int i = 0; i < rows; i++)
    matrix[i] = Console.ReadLine()!.Split();
int count = 0;
for (int r = 0; r < rows - 1; r++)
    for (int c = 0; c < cols - 1; c++)
        if (matrix[r][c] == matrix[r][c + 1] && matrix[r][c] == matrix[r + 1][c] && matrix[r][c] == matrix[r + 1][c + 1])
            count++;
Console.WriteLine(count);
