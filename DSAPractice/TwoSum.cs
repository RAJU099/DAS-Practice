using System;

public class TwoSum
{
    public static void Run()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        var result = FindTwoSum(nums, target);
        Console.WriteLine($"Indexes: {result[0]}, {result[1]}");
    }

    public static int[] FindTwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (map.ContainsKey(diff))
                return new int[] { map[diff], i };
            map[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
