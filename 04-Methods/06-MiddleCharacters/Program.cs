string s = Console.ReadLine()!;
int mid = s.Length / 2;
Console.WriteLine(s.Length % 2 == 0 ? $"{s[mid-1]}{s[mid]}" : $"{s[mid]}");
