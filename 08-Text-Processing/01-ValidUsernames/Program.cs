foreach (var name in Console.ReadLine()!.Split(", "))
    if (name.Length >= 3 && name.Length <= 16 && name.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_'))
        Console.WriteLine(name);
