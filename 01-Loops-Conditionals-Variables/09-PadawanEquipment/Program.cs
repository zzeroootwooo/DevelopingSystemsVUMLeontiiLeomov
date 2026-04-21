double money = double.Parse(Console.ReadLine()!);
int students = int.Parse(Console.ReadLine()!);
double saberPrice = double.Parse(Console.ReadLine()!);
double robePrice = double.Parse(Console.ReadLine()!);
double beltPrice = double.Parse(Console.ReadLine()!);

int sabers = (int)Math.Ceiling(students * 1.1);
int robes = students;
int belts = students - students / 6;

double total = sabers * saberPrice + robes * robePrice + belts * beltPrice;
if (total <= money)
    Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
else
    Console.WriteLine($"John will need {(total - money):F2}lv more.");
