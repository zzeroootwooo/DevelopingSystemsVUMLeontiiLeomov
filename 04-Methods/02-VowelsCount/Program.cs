string s = Console.ReadLine()!.ToLower();
Console.WriteLine(s.Count(ch => "aeiou".Contains(ch)));
