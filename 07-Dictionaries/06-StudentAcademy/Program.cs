int n = int.Parse(Console.ReadLine()!);
var students = new Dictionary<string, List<double>>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine()!;
    double grade = double.Parse(Console.ReadLine()!);
    if (!students.ContainsKey(name)) students[name] = new List<double>();
    students[name].Add(grade);
}
foreach (var kv in students)
{
    double avg = kv.Value.Average();
    if (avg >= 4.50) Console.WriteLine($"{kv.Key} -> {avg:F2}");
}
