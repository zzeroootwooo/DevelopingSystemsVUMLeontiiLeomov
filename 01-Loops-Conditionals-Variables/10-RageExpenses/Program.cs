int games = int.Parse(Console.ReadLine()!);
double headset = double.Parse(Console.ReadLine()!);
double mouse = double.Parse(Console.ReadLine()!);
double keyboard = double.Parse(Console.ReadLine()!);
double display = double.Parse(Console.ReadLine()!);

int headsets = games / 2;
int mice = games / 3;
int keyboards = 0;
for (int i = 1; i <= games; i++)
    if (i % 2 == 0 && i % 3 == 0) keyboards++;
int displays = keyboards / 2;

double total = headsets * headset + mice * mouse + keyboards * keyboard + displays * display;
Console.WriteLine($"Rage expenses: {total:F2} lv.");
