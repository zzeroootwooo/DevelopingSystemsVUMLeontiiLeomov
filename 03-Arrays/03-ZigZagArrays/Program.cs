int n = int.Parse(Console.ReadLine()!);
int[] a1 = new int[n], a2 = new int[n];
for (int i = 0; i < n; i++)
{
    int[] p = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    if (i % 2 == 0) { a1[i] = p[0]; a2[i] = p[1]; }
    else             { a1[i] = p[1]; a2[i] = p[0]; }
}
Console.WriteLine(string.Join(" ", a1));
Console.WriteLine(string.Join(" ", a2));
