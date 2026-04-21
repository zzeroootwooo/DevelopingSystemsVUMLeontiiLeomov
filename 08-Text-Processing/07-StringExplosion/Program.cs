string input = Console.ReadLine()!;
var sb = new System.Text.StringBuilder();
int skip = 0;
for (int i = 0; i < input.Length; i++)
{
    char c = input[i];
    if (c == '>')
    {
        sb.Append(c);
        i++;
        skip += input[i] - '0';
    }
    else if (skip > 0)
    {
        skip--;
    }
    else
    {
        sb.Append(c);
    }
}
Console.WriteLine(sb);
