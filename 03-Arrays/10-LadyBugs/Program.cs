int size = int.Parse(Console.ReadLine()!);
bool[] field = new bool[size];
foreach (var s in Console.ReadLine()!.Split())
{
    int i = int.Parse(s);
    if (i >= 0 && i < size) field[i] = true;
}
string? line;
while ((line = Console.ReadLine()) != "end")
{
    string[] parts = line!.Split();
    int bugIdx = int.Parse(parts[0]);
    string dir = parts[1];
    int flyLen = int.Parse(parts[2]);
    if (bugIdx < 0 || bugIdx >= size || !field[bugIdx]) continue;
    field[bugIdx] = false;
    int step = dir == "right" ? flyLen : -flyLen;
    int newIdx = bugIdx + step;
    while (newIdx >= 0 && newIdx < size)
    {
        if (!field[newIdx]) { field[newIdx] = true; break; }
        newIdx += step;
    }
}
Console.WriteLine(string.Join(" ", field.Select(x => x ? 1 : 0)));
