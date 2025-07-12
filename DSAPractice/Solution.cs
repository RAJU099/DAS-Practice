public class Solution
{
    public static void MaxSubArray()
    {
        var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int maxSum = -100000;
        int currentSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            maxSum = Math.Max(currentSum, maxSum);

            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }
        Console.WriteLine($"maximum subarray sum --> {maxSum}");
    }
}