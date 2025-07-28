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
        StackusingArray stack = new StackusingArray(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.PrintStack();

        Randdom.RanddomGenerateUsingArray();
        Randdom.RanddomGenerateUsingList();

        // list Implementation
        var obj = new Operation();
        obj.PushFront(16);
        obj.PushFront(17);
        obj.PushFront(18);
        obj.PushFront(19);
        //obj.PushEnd(20);
        //obj.PrintList();
        //obj.PopFront();
        //obj.PrintList();
        //obj.PopBack();
        //obj.PrintList();

        obj.Insert(87, 4);
        obj.PrintList();
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
