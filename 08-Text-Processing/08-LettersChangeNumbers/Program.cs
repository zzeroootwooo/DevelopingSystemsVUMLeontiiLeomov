double total = 0;
foreach (var token in Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries))
{
    char first = token[0];
    char last = token[^1];
    string numStr = token[1..^1];
    double num = double.Parse(numStr);
    int firstPos = char.ToUpper(first) - 'A' + 1;
    int lastPos = char.ToUpper(last) - 'A' + 1;
    if (char.IsUpper(first)) num /= firstPos;
    else num *= firstPos;
    if (char.IsUpper(last)) num -= lastPos;
    else num += lastPos;
    total += num;
}
Console.WriteLine($"{total:F2}");
