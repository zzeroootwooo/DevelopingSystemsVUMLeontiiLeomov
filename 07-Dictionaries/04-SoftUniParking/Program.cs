var parking = new Dictionary<string, string>();
int n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < n; i++)
{
    var parts = Console.ReadLine()!.Split();
    if (parts[0] == "register")
    {
        string user = parts[1], plate = parts[2];
        if (parking.ContainsKey(user))
            Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
        else
        {
            parking[user] = plate;
            Console.WriteLine($"{user} registered {plate} successfully");
        }
    }
    else
    {
        string user = parts[1];
        if (!parking.ContainsKey(user))
            Console.WriteLine($"ERROR: user {user} not found");
        else
        {
            parking.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
    }
}
foreach (var kv in parking)
    Console.WriteLine($"{kv.Key} => {kv.Value}");
