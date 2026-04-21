int n = int.Parse(Console.ReadLine()!);
int[] fact = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
int sum = 0, temp = n;
while (temp > 0) { sum += fact[temp % 10]; temp /= 10; }
Console.WriteLine(sum == n ? "yes" : "no");
