int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int Sum(int x, int y) => x + y;
int Subtract(int s, int z) => s - z;
Console.WriteLine(Subtract(Sum(a, b), c));
