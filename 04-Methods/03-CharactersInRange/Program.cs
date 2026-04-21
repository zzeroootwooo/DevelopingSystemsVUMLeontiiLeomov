char a = Console.ReadLine()![0];
char b = Console.ReadLine()![0];
if (a > b) (a, b) = (b, a);
for (char c = (char)(a + 1); c < b; c++) Console.Write(c + " ");
Console.WriteLine();
