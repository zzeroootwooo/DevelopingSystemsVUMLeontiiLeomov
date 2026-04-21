int n = int.Parse(Console.ReadLine()!);
var pumps = new (long petrol, long dist)[n];
for (int i = 0; i < n; i++)
{
    var p = Console.ReadLine()!.Split();
    pumps[i] = (long.Parse(p[0]), long.Parse(p[1]));
}
int start = 0;
while (start < n)
{
    long tank = 0;
    bool ok = true;
    for (int i = 0; i < n; i++)
    {
        int idx = (start + i) % n;
        tank += pumps[idx].petrol - pumps[idx].dist;
        if (tank < 0) { ok = false; break; }
    }
    if (ok) { Console.WriteLine(start); return; }
    start++;
}
