var people = new Dictionary<string, (string name, int age)>();
string? line;
while ((line = Console.ReadLine()) != "End")
{
    var p = line!.Split();
    people[p[1]] = (p[0], int.Parse(p[2]));
}
foreach (var kv in people.OrderBy(kv => kv.Value.age))
    Console.WriteLine($"{kv.Value.name} with ID: {kv.Key} is {kv.Value.age} years old.");
