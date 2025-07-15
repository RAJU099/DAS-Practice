using System;
namespace DSAPractice
{
	public class IndicesMaximumSubArray
	{
        public static void IndicesMaxSubArray()
        {
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = -100000;
            int currentSum = 0;
            int start = 0;
            int end = 0;
            int tempStart = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = tempStart;
                    end = i;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                    tempStart = i + 1;
                }
            }
            Console.WriteLine($"maximum subarray sum --> {maxSum}");
            Console.WriteLine($"maximum subarray sum indices --> {start}----{end}");
        }
    }
}

