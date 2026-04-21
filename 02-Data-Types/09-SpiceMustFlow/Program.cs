int yield = int.Parse(Console.ReadLine()!);
if (yield < 100) { Console.WriteLine(0); Console.WriteLine(0); return; }
int days = 0, storage = 0;
while (yield >= 100)
{
    storage += yield;
    days++;
    storage -= 26;
    if (storage < 0) storage = 0;
    yield -= 10;
}
storage -= 26;
if (storage < 0) storage = 0;
Console.WriteLine(days);
Console.WriteLine(storage);
