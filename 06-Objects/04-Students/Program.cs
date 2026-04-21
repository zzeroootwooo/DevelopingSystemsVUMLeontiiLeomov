int n = int.Parse(Console.ReadLine()!);
var students = new List<(string first, string last, double grade)>();
for (int i = 0; i < n; i++)
{
    var p = Console.ReadLine()!.Split();
    students.Add((p[0], p[1], double.Parse(p[2])));
}
foreach (var s in students.OrderByDescending(s => s.grade))
    Console.WriteLine($"{s.first} {s.last}: {s.grade:F2}");
