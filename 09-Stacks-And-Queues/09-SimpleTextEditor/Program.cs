int n = int.Parse(Console.ReadLine()!);
var text = new System.Text.StringBuilder();
var history = new Stack<string>();
for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine()!;
    if (line.StartsWith("1 "))
    {
        history.Push(text.ToString());
        text.Append(line[2..]);
    }
    else if (line.StartsWith("2 "))
    {
        history.Push(text.ToString());
        int count = int.Parse(line[2..]);
        text.Remove(text.Length - count, count);
    }
    else if (line.StartsWith("3 "))
    {
        int idx = int.Parse(line[2..]) - 1;
        Console.WriteLine(text[idx]);
    }
    else
    {
        text.Clear();
        text.Append(history.Pop());
    }
}
