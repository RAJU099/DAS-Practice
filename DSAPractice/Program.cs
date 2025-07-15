using System;
using System.Collections.Generic;
using DSAPractice;

public class Program
{
    public static void Main()
    {
        var item = new int[] { 1, 4, 1, 2, 5, 3, 6 };
        CountFrequencyUsingLinq(item);
        CountFrequency(item);
        TwoSum.Run();
        ValidPalindrome.Run();
        DuplicateElement.Duplicate();
        MinimumProduct.Minimum();
        Solution.MaxSubArray();
        IndicesMaximumSubArray.IndicesMaxSubArray();
        LongestCommonPrefix.CommonPrefix();
        LongestKunique.LongestKuniqueSubstring();
        LengthOfLongestSubstring.LengthOfLongestSubstringallUnique();
    }

    private static void CountFrequencyUsingLinq(int[] item)
    {
        var freq = item.GroupBy(x => x).Select(g => new { Number = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);
        foreach (var f in freq)
            Console.WriteLine($"{f.Number} => {f.Count}");
    }

    private static void CountFrequency(int[] item)
    {
        var dict = new Dictionary<int, int>();
        foreach (var it in item)
        {
            if (dict.ContainsKey(it))
            {
                dict[it]++;
            }
            else
            {
                dict[it] = 1;
            }
        }

        Console.WriteLine($"using dictinary approach");
        // Optional: Print the frequencies
        foreach (var kvp in dict)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
    }
}
