int n = int.Parse(Console.ReadLine()!);
var stack = new Stack<int>();
var maxStack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine()!.Split();
    int type = int.Parse(line[0]);
    if (type == 1)
    {
        int x = int.Parse(line[1]);
        stack.Push(x);
        maxStack.Push(maxStack.Count == 0 ? x : Math.Max(x, maxStack.Peek()));
    }
    else if (type == 2)
    {
        stack.Pop();
        maxStack.Pop();
    }
    else
    {
        Console.WriteLine(maxStack.Peek());
    }
}
