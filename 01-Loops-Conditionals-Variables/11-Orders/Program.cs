int n = int.Parse(Console.ReadLine()!);
double total = 0;
for (int i = 0; i < n; i++)
{
    double price = double.Parse(Console.ReadLine()!);
    int days = int.Parse(Console.ReadLine()!);
    int capsules = int.Parse(Console.ReadLine()!);
    double orderPrice = days * capsules * price;
    total += orderPrice;
    Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
}
Console.WriteLine($"Total: ${total:F2}");
