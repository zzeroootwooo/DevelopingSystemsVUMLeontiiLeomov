var rc = Console.ReadLine()!.Split();
int R = int.Parse(rc[0]), C = int.Parse(rc[1]);
var parking = new bool[R, C];

string? line;
while ((line = Console.ReadLine()) != "stop")
{
    var p = line!.Split();
    int entryRow = int.Parse(p[0]);
    int destRow = int.Parse(p[1]), destCol = int.Parse(p[2]);

    if (!FindSpot(entryRow, destRow, destCol, out int spotCol))
    {
        Console.WriteLine($"Row {entryRow} full");
        continue;
    }
    parking[destRow, spotCol] = true;
    int dist = 1 + Math.Abs(entryRow - destRow) + spotCol;
    Console.WriteLine(dist);
}

bool FindSpot(int entryRow, int destRow, int destCol, out int spotCol)
{
    if (!parking[destRow, destCol]) { spotCol = destCol; return true; }
    int left = destCol - 1, right = destCol + 1;
    while (left >= 1 || right < C)
    {
        if (left >= 1 && !parking[destRow, left]) { spotCol = left; return true; }
        if (right < C && !parking[destRow, right]) { spotCol = right; return true; }
        left--; right++;
    }
    spotCol = -1;
    return false;
}
