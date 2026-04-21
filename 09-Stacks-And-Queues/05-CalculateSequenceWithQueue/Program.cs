long n = long.Parse(Console.ReadLine()!);
var queue = new Queue<long>();
queue.Enqueue(n);
var result = new List<long>();
while (result.Count < 50)
{
    long s = queue.Dequeue();
    result.Add(s);
    queue.Enqueue(s + 1);
    queue.Enqueue(2 * s + 1);
    queue.Enqueue(s + 2);
}
Console.WriteLine(string.Join(" ", result));
