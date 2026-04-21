var schedule = Console.ReadLine()!.Split(", ").ToList();
string? line;
while ((line = Console.ReadLine()) != "course start")
{
    string[] p = line!.Split(':');
    string cmd = p[0];
    if (cmd == "Add")
    {
        if (!schedule.Contains(p[1])) schedule.Add(p[1]);
    }
    else if (cmd == "Insert")
    {
        if (!schedule.Contains(p[1])) schedule.Insert(int.Parse(p[2]), p[1]);
    }
    else if (cmd == "Remove")
    {
        int i = schedule.IndexOf(p[1]);
        if (i == -1) continue;
        schedule.RemoveAt(i);
        if (i < schedule.Count && schedule[i] == p[1] + "-Exercise") schedule.RemoveAt(i);
    }
    else if (cmd == "Swap")
    {
        int i1 = schedule.IndexOf(p[1]), i2 = schedule.IndexOf(p[2]);
        if (i1 == -1 || i2 == -1) continue;
        if (i1 > i2) { (i1, i2) = (i2, i1); (p[1], p[2]) = (p[2], p[1]); }
        bool ex1 = i1 + 1 < schedule.Count && schedule[i1 + 1] == p[1] + "-Exercise";
        bool ex2 = i2 + 1 < schedule.Count && schedule[i2 + 1] == p[2] + "-Exercise";
        var b1 = ex1 ? new List<string>{p[1], p[1]+"-Exercise"} : new List<string>{p[1]};
        var b2 = ex2 ? new List<string>{p[2], p[2]+"-Exercise"} : new List<string>{p[2]};
        schedule.RemoveRange(i2, b2.Count);
        schedule.InsertRange(i2, b1);
        schedule.RemoveRange(i1, b1.Count);
        schedule.InsertRange(i1, b2);
    }
    else if (cmd == "Exercise")
    {
        int i = schedule.IndexOf(p[1]);
        string ex = p[1] + "-Exercise";
        if (i != -1)
        {
            if (!schedule.Contains(ex)) schedule.Insert(i + 1, ex);
        }
        else
        {
            schedule.Add(p[1]);
            schedule.Add(ex);
        }
    }
}
for (int i = 0; i < schedule.Count; i++) Console.WriteLine($"{i+1}.{schedule[i]}");
