string? line;
while ((line = Console.ReadLine()) != null)
{
    var stack = new Stack<char>();
    bool balanced = true;
    foreach (var c in line)
    {
        if (c == '(' || c == '{' || c == '[') stack.Push(c);
        else
        {
            if (stack.Count == 0) { balanced = false; break; }
            char top = stack.Pop();
            if (c == ')' && top != '(' || c == '}' && top != '{' || c == ']' && top != '[')
            { balanced = false; break; }
        }
    }
    Console.WriteLine(balanced && stack.Count == 0 ? "YES" : "NO");
}
