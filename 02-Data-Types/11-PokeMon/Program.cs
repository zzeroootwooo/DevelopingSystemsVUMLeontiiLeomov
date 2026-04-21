long n = long.Parse(Console.ReadLine()!);
long m = long.Parse(Console.ReadLine()!);
long y = long.Parse(Console.ReadLine()!);
long original = n;
long count = 0;
bool divided = false;

while (n >= m)
{
    n -= m;
    count++;
    if (!divided && original % 2 == 0 && n == original / 2 && y != 0)
    {
        n /= y;
        divided = true;
    }
}
Console.WriteLine(n);
Console.WriteLine(count);
