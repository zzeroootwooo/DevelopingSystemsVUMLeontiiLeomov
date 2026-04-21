int[] nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int target = int.Parse(Console.ReadLine()!);
for (int i = 0; i < nums.Length - 1; i++)
    for (int j = i + 1; j < nums.Length; j++)
        if (nums[i] + nums[j] == target)
            Console.WriteLine($"{nums[i]} {nums[j]}");
