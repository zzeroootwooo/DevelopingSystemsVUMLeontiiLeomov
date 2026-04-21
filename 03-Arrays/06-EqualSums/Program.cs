int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
for (int i = 0; i < arr.Length; i++)
{
    if (arr[..i].Sum() == arr[(i+1)..].Sum()) { Console.WriteLine(i); return; }
}
Console.WriteLine("no");
