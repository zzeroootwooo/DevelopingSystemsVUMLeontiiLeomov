int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
double Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
Console.WriteLine($"{Factorial(a) / Factorial(b):F2}");
