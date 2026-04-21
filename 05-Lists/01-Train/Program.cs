var wagons = Console.ReadLine()!.Split().Select(int.Parse).ToList();
int capacity = int.Parse(Console.ReadLine()!);
string? line;
while ((line = Console.ReadLine()) != "end")
{
    if (line!.StartsWith("Add "))
        wagons.Add(int.Parse(line.Substring(4)));
    else
    {
        int passengers = int.Parse(line);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (capacity - wagons[i] >= passengers) { wagons[i] += passengers; break; }
        }
    }
}
Console.WriteLine(string.Join(" ", wagons));
