string[] arr1 = Console.ReadLine()!.Split();
string[] arr2 = Console.ReadLine()!.Split();
var common = arr2.Where(e => arr1.Contains(e));
Console.WriteLine(string.Join(" ", common));
