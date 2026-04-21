var courses = new Dictionary<string, List<string>>();
string? line;
while ((line = Console.ReadLine()) != "end")
{
    var p = line!.Split(" : ");
    string course = p[0], student = p[1];
    if (!courses.ContainsKey(course)) courses[course] = new List<string>();
    courses[course].Add(student);
}
foreach (var kv in courses)
{
    Console.WriteLine($"{kv.Key}: {kv.Value.Count}");
    foreach (var s in kv.Value) Console.WriteLine($"-- {s}");
}
