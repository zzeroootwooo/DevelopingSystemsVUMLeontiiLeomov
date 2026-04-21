int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int rot = int.Parse(Console.ReadLine()!) % arr.Length;
Console.WriteLine(string.Join(" ", arr[rot..].Concat(arr[..rot])));
