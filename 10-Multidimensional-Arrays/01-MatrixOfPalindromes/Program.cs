var rc = Console.ReadLine()!.Split();
int r = int.Parse(rc[0]), c = int.Parse(rc[1]);
for (int row = 0; row < r; row++)
{
    var cells = new string[c];
    for (int col = 0; col < c; col++)
    {
        char first = (char)('a' + row);
        char mid = (char)('a' + row + col);
        cells[col] = $"{first}{mid}{first}";
    }
    Console.WriteLine(string.Join(" ", cells));
}
