string s1 = Console.ReadLine()!;
string s2 = Console.ReadLine()!;
long sum = 0;
int len = Math.Max(s1.Length, s2.Length);
for (int i = 0; i < len; i++)
{
    if (i < s1.Length && i < s2.Length) sum += s1[i] * s2[i];
    else if (i < s1.Length) sum += s1[i];
    else sum += s2[i];
}
Console.WriteLine(sum);
