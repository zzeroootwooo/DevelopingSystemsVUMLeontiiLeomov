var stack = new Stack<int>(Console.ReadLine()!.Split().Select(int.Parse));
Console.WriteLine(string.Join(" ", stack));
