using System;
namespace DSAPractice
{
	public class Randdom
	{
		public static void RanddomGenerateUsingList()
		{
            int [] list = new int [] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Random random = new Random();
            int size = list.Length;
            while (size > 0)
            {
                int index = random.Next(size);
                int value = list[index];

                Console.WriteLine("Picked: " + value);

                list[index] = list[size - 1];
                size--;
            }
        }

        public static void RanddomGenerateUsingArray()
        {
            List<int> list = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Random random = new Random();

            while (list.Count > 0)
            {
                int index = random.Next(list.Count);
                int value = list[index];

                Console.WriteLine("Picked: " + value);

                list[index] = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}

