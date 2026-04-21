int n = int.Parse(Console.ReadLine()!);
var plants = Console.ReadLine()!.Split().Select(long.Parse).ToList();
int days = 0;
while (true)
{
    var toRemove = new List<int>();
    for (int i = 1; i < plants.Count; i++)
        if (plants[i] > plants[i - 1]) toRemove.Add(i);
    if (toRemove.Count == 0) break;
    for (int i = toRemove.Count - 1; i >= 0; i--)
        plants.RemoveAt(toRemove[i]);
    days++;
}
Console.WriteLine(days);
