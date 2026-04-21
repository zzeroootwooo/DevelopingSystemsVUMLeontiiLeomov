var data = Console.ReadLine()!.Split().ToList();
string? line;
while ((line = Console.ReadLine()) != "3:1")
{
    string[] p = line!.Split();
    if (p[0] == "merge")
    {
        int s = Math.Max(0, int.Parse(p[1]));
        int e = Math.Min(data.Count - 1, int.Parse(p[2]));
        if (s > e) continue;
        string merged = string.Concat(data.GetRange(s, e - s + 1));
        data.RemoveRange(s, e - s + 1);
        data.Insert(s, merged);
    }
    else
    {
        int idx = int.Parse(p[1]), parts = int.Parse(p[2]);
        string str = data[idx];
        int partLen = str.Length / parts;
        var newParts = new List<string>();
        int pos = 0;
        for (int i = 0; i < parts - 1; i++) { newParts.Add(str.Substring(pos, partLen)); pos += partLen; }
        newParts.Add(str.Substring(pos));
        data.RemoveAt(idx);
        data.InsertRange(idx, newParts);
    }
}
Console.WriteLine(string.Join(" ", data));
