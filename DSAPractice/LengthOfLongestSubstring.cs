using System;
namespace DSAPractice
{
	public class LengthOfLongestSubstring
	{
		public static void LengthOfLongestSubstringallUnique()
		{
            int left = 0, right = 0, maxLength = 0;
            string s = "abcabcbb";
            HashSet<char> seen = new HashSet<char>();

            while (right < s.Length)
            {
                if (!seen.Contains(s[right]))
                {
                    seen.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    seen.Remove(s[left]);
                    left++;
                }
            }

            Console.WriteLine($"maximum length of all non repeating string ---> {maxLength}");
        }
	}
}

