var first = Console.ReadLine()!.Split();
int n = int.Parse(first[0]), s = int.Parse(first[1]), x = int.Parse(first[2]);
var nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
var queue = new Queue<int>();
for (int i = 0; i < n; i++) queue.Enqueue(nums[i]);
for (int i = 0; i < s; i++) if (queue.Count > 0) queue.Dequeue();
if (queue.Count == 0) { Console.WriteLine(0); return; }
if (queue.Contains(x)) Console.WriteLine("true");
else Console.WriteLine(queue.Min());
