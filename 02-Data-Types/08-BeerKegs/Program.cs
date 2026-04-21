int n = int.Parse(Console.ReadLine()!);
double maxVol = double.MinValue;
string best = "";
for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine()!;
    double r = double.Parse(Console.ReadLine()!);
    int h = int.Parse(Console.ReadLine()!);
    double vol = Math.PI * r * r * h;
    if (vol > maxVol) { maxVol = vol; best = model; }
}
Console.WriteLine(best);
