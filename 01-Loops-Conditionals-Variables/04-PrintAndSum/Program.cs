int start = int.Parse(Console.ReadLine()!);
int end = int.Parse(Console.ReadLine()!);
long sum = 0;
for (int i = start; i <= end; i++)
{
    Console.Write(i);
    if (i < end) Console.Write(" ");
    sum += i;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
