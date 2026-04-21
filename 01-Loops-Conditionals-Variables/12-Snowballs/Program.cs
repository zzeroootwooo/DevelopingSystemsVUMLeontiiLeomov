int n = int.Parse(Console.ReadLine()!);
double bestValue = double.MinValue;
int bestSnow = 0, bestTime = 0, bestQuality = 0;
for (int i = 0; i < n; i++)
{
    int snow = int.Parse(Console.ReadLine()!);
    int time = int.Parse(Console.ReadLine()!);
    int quality = int.Parse(Console.ReadLine()!);
    double value = Math.Pow((double)snow / time, quality);
    if (value > bestValue)
    {
        bestValue = value; bestSnow = snow; bestTime = time; bestQuality = quality;
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
