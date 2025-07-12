using System;
namespace DSAPractice
{
	public class MinimumProduct
	{
		public static void Minimum ()
		{
			var input = new int[] { 1, 4, 4 };
			var minValue = int.MaxValue;

			for(int i = 0; i < input.Length-1; i++)
			{
				for(int j = i+1; j <input.Length; j++)
				{
					int product = input[i] * input[j];
					minValue = Math.Min(product, minValue);
				}
			}
			Console.WriteLine($"minimum product is -> {minValue}");
		}
	}
}

