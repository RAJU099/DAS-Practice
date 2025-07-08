using System;
using System.Text.RegularExpressions;

public class ValidPalindrome
{
    public static void Run()
    {
        string s = "A man, a plan, a canal: Panama";
        Palindrome(s);
        PalinddromUsingTwoPointer(s);


    }
    public static void Palindrome(string s)
    {
        string regex = "[^A-Za-z0-9]";
        var cleanString = Regex.Replace(s, regex, "").ToLower();

        for (int i = 0; i < s.Length/2; i++)
        {
            if (cleanString[i] != cleanString[cleanString.Length - i - 1])
            {
                Console.WriteLine($"it is not a valid palindrome");
            }
        }
        Console.WriteLine($"it is a valid palindrome");
    }

    public static void PalinddromUsingTwoPointer(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Skip non-alphanumeric from the left
            while (left < right && !Char.IsLetterOrDigit(s[left]))
                left++;

            // Skip non-alphanumeric from the right
            while (left < right && !Char.IsLetterOrDigit(s[right]))
                right--;

            // Compare lowercase versions
            if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                Console.WriteLine($"it is not a valid palindrome");

            left++;
            right--;
        }

        Console.WriteLine($"it is a valid palindrome");

    }
}

