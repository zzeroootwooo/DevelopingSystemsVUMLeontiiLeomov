double balance = 0;
double[] validCoins = { 0.1, 0.2, 0.5, 1.0, 2.0 };
var products = new Dictionary<string, double>
{
    { "Nuts", 2.0 }, { "Water", 0.7 }, { "Crisps", 1.5 }, { "Soda", 0.8 }, { "Coke", 1.0 }
};

string input;
while ((input = Console.ReadLine()!) != "Start")
{
    if (double.TryParse(input, System.Globalization.NumberStyles.Any,
        System.Globalization.CultureInfo.InvariantCulture, out double coin)
        && validCoins.Contains(coin))
        balance += coin;
    else
        Console.WriteLine($"Cannot accept {input}");
}

while ((input = Console.ReadLine()!) != "End")
{
    if (!products.ContainsKey(input)) { Console.WriteLine("Invalid product"); continue; }
    double price = products[input];
    if (balance >= price) { balance -= price; Console.WriteLine($"Purchased {input.ToLower()}"); }
    else Console.WriteLine("Sorry, not enough money");
}
Console.WriteLine($"Change: {balance:F2}");
