int n = int.Parse(Console.ReadLine()!);
int[] wagons = new int[n];
int total = 0;
for (int i = 0; i < n; i++) { wagons[i] = int.Parse(Console.ReadLine()!); total += wagons[i]; }
Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(total);
