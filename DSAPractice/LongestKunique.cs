using System;
namespace DSAPractice
{
	public class LongestKunique
	{
		public static void LongestKuniqueSubstring()
		{
			string s = "aabacbebebe";
			int k = 3;
            CheckLongest(s,k);
        }

		private static void CheckLongest(string s, int k)
		{
			int i = 0;
			int j = 0;
			int maxLength = 0;
			var dict = new Dictionary<char, int>();

			while(j <s.Length)
			{
				if (!dict.ContainsKey(s[j]))
				{
					dict[s[j]] = 1;
				}
				else
				{
					dict[s[j]]++;
				}


				if(dict.Count < k)
				{
					j++;
				}

				else if(dict.Count == k)
				{
					maxLength = Math.Max(maxLength, j - i + 1);
					j++;
				}

				else if(dict.Count > k)
				{
					while (dict.Count > k)
					{
						dict[s[i]]--;

						if (dict[s[i]] == 0)
						{
							dict.Remove(s[i]);
						}
                        i++;
                    }
				}
			}
			Console.WriteLine($"maximum length ---> {maxLength}");
		}

    }
}

