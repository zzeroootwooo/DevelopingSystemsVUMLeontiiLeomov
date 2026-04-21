var p1 = new Queue<int>(Console.ReadLine()!.Split().Select(int.Parse));
var p2 = new Queue<int>(Console.ReadLine()!.Split().Select(int.Parse));
while (p1.Count > 0 && p2.Count > 0)
{
    int c1 = p1.Dequeue(), c2 = p2.Dequeue();
    if (c1 > c2) { p1.Enqueue(c2); p1.Enqueue(c1); }
    else if (c2 > c1) { p2.Enqueue(c1); p2.Enqueue(c2); }
}
if (p1.Count > 0) Console.WriteLine($"First player wins! Sum: {p1.Sum()}");
else Console.WriteLine($"Second player wins! Sum: {p2.Sum()}");
