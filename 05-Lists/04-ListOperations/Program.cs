var list = Console.ReadLine()!.Split().Select(int.Parse).ToList();
string? line;
while ((line = Console.ReadLine()) != "End")
{
    string[] p = line!.Split();
    switch (p[0])
    {
        case "Add": list.Add(int.Parse(p[1])); break;
        case "Insert":
        {
            int idx = int.Parse(p[2]);
            if (idx < 0 || idx >= list.Count) Console.WriteLine("Invalid index");
            else list.Insert(idx, int.Parse(p[1]));
            break;
        }
        case "Remove":
        {
            int idx = int.Parse(p[1]);
            if (idx < 0 || idx >= list.Count) Console.WriteLine("Invalid index");
            else list.RemoveAt(idx);
            break;
        }
        case "Shift":
        {
            int count = list.Count == 0 ? 0 : int.Parse(p[2]) % list.Count;
            if (p[1] == "left")
                for (int i = 0; i < count; i++) { list.Add(list[0]); list.RemoveAt(0); }
            else
                for (int i = 0; i < count; i++) { list.Insert(0, list[^1]); list.RemoveAt(list.Count - 1); }
            break;
        }
    }
}
Console.WriteLine(string.Join(" ", list));
