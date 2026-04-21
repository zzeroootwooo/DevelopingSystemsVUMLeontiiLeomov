var first = Console.ReadLine()!.Split();
int n = int.Parse(first[0]), s = int.Parse(first[1]), x = int.Parse(first[2]);
var nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
var stack = new Stack<int>();
for (int i = 0; i < n; i++) stack.Push(nums[i]);
for (int i = 0; i < s; i++) if (stack.Count > 0) stack.Pop();
if (stack.Count == 0) { Console.WriteLine(0); return; }
if (stack.Contains(x)) Console.WriteLine("true");
else Console.WriteLine(stack.Min());
