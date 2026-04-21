var vehicles = new Dictionary<string, Vehicle>();
string? line;
while ((line = Console.ReadLine()) != "End")
{
    var p = line!.Split();
    vehicles[p[1]] = new Vehicle(p[0], p[1], p[2], int.Parse(p[3]));
}
while ((line = Console.ReadLine()) != "Close the Catalogue")
{
    var v = vehicles[line!];
    Console.WriteLine($"Type: {v.Type}");
    Console.WriteLine($"Model: {v.Model}");
    Console.WriteLine($"Color: {v.Color}");
    Console.WriteLine($"Horsepower: {v.Horsepower}");
}
var cars = vehicles.Values.Where(v => v.Type == "car").ToList();
var trucks = vehicles.Values.Where(v => v.Type == "truck").ToList();
double carAvg = cars.Count > 0 ? cars.Average(v => v.Horsepower) : 0;
double truckAvg = trucks.Count > 0 ? trucks.Average(v => v.Horsepower) : 0;
Console.WriteLine($"Cars have average horsepower of: {carAvg:F2}.");
Console.WriteLine($"Trucks have average horsepower of: {truckAvg:F2}.");

record Vehicle(string Type, string Model, string Color, int Horsepower);
