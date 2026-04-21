int n = int.Parse(Console.ReadLine()!);
var stack = new Stack<long>();
stack.Push(0);
stack.Push(1);
while (stack.Count < n)
{
    long a = stack.Pop();
    long b = stack.Peek();
    stack.Push(a);
    stack.Push(a + b);
}
var result = stack.ToArray();
Array.Reverse(result);
Console.WriteLine(result[n - 1]);
