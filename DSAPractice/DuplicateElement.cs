using System;
public class DuplicateElement
{
    public static void Duplicate()
    {
        var arry = new int[] { 1, 3, 2, 3, 5, 5 };
        var set = new HashSet<int>();

        foreach (var item in arry)
        {
            if (set.Contains(item))
            {
                Console.WriteLine($"duplicate element is {item}");

            }
            set.Add(item);
        }
    }
}

