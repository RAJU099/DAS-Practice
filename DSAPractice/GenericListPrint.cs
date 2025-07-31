using System;
namespace DSAPractice
{
	public static class GenericListPrint
	{
		public static List<List<T>> MergeList<T>(this List<T> list, int size)
		{
			if(size <= 0)
			{
				throw new ArgumentException("not good");
			}

			var result = new List<List<T>>(size);
			var chunck = new List<T>(size);

			foreach(T item in list)
			{
				chunck.Add(item);

				if(chunck.Count == size)
				{
					result.Add(new List<T>(chunck));
					chunck.Clear();
				}
			}

			if(chunck.Count > 0)
			{
				result.Add(chunck);
			}

			return result;
		}
	}
}

