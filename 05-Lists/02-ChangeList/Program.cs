var list = Console.ReadLine()!.Split().Select(int.Parse).ToList();
string? line;
while ((line = Console.ReadLine()) != "end")
{
    string[] p = line!.Split();
    if (p[0] == "Delete") list.RemoveAll(x => x == int.Parse(p[1]));
    else list.Insert(int.Parse(p[2]), int.Parse(p[1]));
}
Console.WriteLine(string.Join(" ", list));
