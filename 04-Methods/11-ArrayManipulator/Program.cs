var arr = Console.ReadLine()!.Split().Select(int.Parse).ToList();
string? cmd;
while ((cmd = Console.ReadLine()) != "end")
{
    string[] parts = cmd!.Split();
    switch (parts[0])
    {
        case "exchange":
        {
            int idx = int.Parse(parts[1]);
            if (idx < 0 || idx >= arr.Count) { Console.WriteLine("Invalid index"); break; }
            var tmp = arr[(idx+1)..].Concat(arr[..(idx+1)]).ToList();
            arr = tmp;
            break;
        }
        case "max":
        case "min":
        {
            bool isEven = parts[1] == "even";
            var matches = arr.Select((v, i) => (v, i)).Where(x => isEven ? x.v % 2 == 0 : x.v % 2 != 0).ToList();
            if (!matches.Any()) { Console.WriteLine("No matches"); break; }
            int target = parts[0] == "max" ? matches.Max(x => x.v) : matches.Min(x => x.v);
            Console.WriteLine(matches.Last(x => x.v == target).i);
            break;
        }
        case "first":
        case "last":
        {
            int count = int.Parse(parts[1]);
            if (count > arr.Count) { Console.WriteLine("Invalid count"); break; }
            bool isEven = parts[2] == "even";
            var filtered = arr.Where(x => isEven ? x % 2 == 0 : x % 2 != 0).ToList();
            var result = parts[0] == "first" ? filtered.Take(count).ToList() : filtered.TakeLast(count).ToList();
            Console.WriteLine($"[{string.Join(", ", result)}]");
            break;
        }
    }
}
Console.WriteLine($"[{string.Join(", ", arr)}]");
