var nm = Console.ReadLine()!.Split();
int n = int.Parse(nm[0]), m = int.Parse(nm[1]);
var setA = new HashSet<int>();
var setB = new HashSet<int>();
for (int i = 0; i < n; i++) setA.Add(int.Parse(Console.ReadLine()!));
for (int i = 0; i < m; i++) setB.Add(int.Parse(Console.ReadLine()!));
foreach (var x in setA.Where(x => setB.Contains(x))) Console.WriteLine(x);
