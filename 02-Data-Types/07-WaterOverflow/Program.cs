int count = int.Parse(Console.ReadLine()!);
int tank = 0;
for (int i = 0; i < count; i++)
{
    int liters = int.Parse(Console.ReadLine()!);
    if (tank + liters > 255) Console.WriteLine("Insufficient capacity!");
    else tank += liters;
}
Console.WriteLine(tank);
