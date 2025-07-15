using System;
namespace DSAPractice
{
	public class LongestCommonPrefix
	{
		public static void CommonPrefix()
		{
            var strs = new string[] { "flower", "flow", "flight" };
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[^1];

            int minLength = Math.Min(first.Length, last.Length);
            int i = 0;
            while (i < minLength && first[i] == last[i])
            {
                i++;
            }
            if(i == 0)
            {
                Console.WriteLine($"no longest common sufix exits");
            }
            else
            {
                Console.WriteLine($"longest common prefix is ---> {first.Substring(0,i)}");
            }
        }
	}
}

