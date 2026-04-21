var products = new Dictionary<string, (double price, int qty)>();
string? line;
while ((line = Console.ReadLine()) != "buy")
{
    var p = line!.Split();
    string name = p[0];
    double price = double.Parse(p[1]);
    int qty = int.Parse(p[2]);
    if (products.TryGetValue(name, out var existing))
        products[name] = (price, existing.qty + qty);
    else
        products[name] = (price, qty);
}
foreach (var kv in products)
    Console.WriteLine($"{kv.Key} -> {kv.Value.price * kv.Value.qty:F2}");
