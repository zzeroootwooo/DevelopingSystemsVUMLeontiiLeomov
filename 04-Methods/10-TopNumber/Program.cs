int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
{
    int sum = 0, t = i;
    while (t > 0) { sum += t % 10; t /= 10; }
    if (sum % 8 == 0 && i.ToString().Any(c => (c - '0') % 2 != 0))
        Console.WriteLine(i);
}
