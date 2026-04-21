string input = Console.ReadLine()!;
var sb = new System.Text.StringBuilder();
for (int i = 0; i < input.Length; i++)
    if (i == 0 || input[i] != input[i - 1])
        sb.Append(input[i]);
Console.WriteLine(sb);
