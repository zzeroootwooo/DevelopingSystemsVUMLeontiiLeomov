string[] arrays = Console.ReadLine()!.Split('|');
var result = new List<int>();
for (int i = arrays.Length - 1; i >= 0; i--)
{
    var nums = arrays[i].Trim().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
    result.AddRange(nums);
}
Console.WriteLine(string.Join(" ", result));
