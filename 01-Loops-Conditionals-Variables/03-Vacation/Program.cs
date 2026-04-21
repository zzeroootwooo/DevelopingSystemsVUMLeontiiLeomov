int people = int.Parse(Console.ReadLine()!);
string type = Console.ReadLine()!;
string day = Console.ReadLine()!;

double price = 0;
if (type == "Students")
{
    if (day == "Friday") price = 8.45;
    else if (day == "Saturday") price = 9.80;
    else price = 10.46;
    double total = people * price;
    if (people >= 30) total *= 0.85;
    Console.WriteLine($"Total price: {total:F2}");
}
else if (type == "Business")
{
    if (day == "Friday") price = 10.90;
    else if (day == "Saturday") price = 15.60;
    else price = 16;
    int payers = people >= 100 ? people - 10 : people;
    Console.WriteLine($"Total price: {payers * price:F2}");
}
else
{
    if (day == "Friday") price = 15;
    else if (day == "Saturday") price = 20;
    else price = 22.50;
    double total = people * price;
    if (people >= 10 && people <= 20) total *= 0.95;
    Console.WriteLine($"Total price: {total:F2}");
}
